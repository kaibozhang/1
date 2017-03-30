using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;

namespace MVVM.VMBase
{
    public class ViewModelBase : IDataErrorInfo, INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyOfPropertyChanged<TProperty>(Expression<Func<TProperty>> property)
        {
            var propertyExpression = property.Body as MemberExpression;
            PropertyInfo prop = propertyExpression.Member as PropertyInfo;
            NotifyPropertyChanged(prop.Name);
        }

        protected void NotifyPropertyChanged(string propertyName)
        {
            if (string.IsNullOrWhiteSpace(propertyName))
            {
                throw new ArgumentNullException("propertyName");
            }

            if (!this.GetType().GetProperties().Any(x => x.Name == propertyName))
            {
                throw new ArgumentException(
                    "The property name does not exist in this type.",
                    "propertyName");
            }

            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }

        }

        public string Error
        {
            get
            {
                StringBuilder error = new StringBuilder();
                PropertyDescriptorCollection props = TypeDescriptor.GetProperties(this);

                foreach (PropertyDescriptor prop in props)
                {
                    string propertyError = this[prop.Name];
                    if (propertyError != string.Empty)
                    {
                        error.Append((error.Length != 0 ? ", " : "") + propertyError);
                    }
                }

                return error.ToString();
            }
        }

        public string this[string columnName]
        {
            get
            {

                Type currentType = this.GetType();
                StringBuilder errors = new StringBuilder();

                var modelClassProperties = TypeDescriptor.GetProperties(this).Cast<PropertyDescriptor>();

                var errormessages = from modelProp in modelClassProperties
                                    where modelProp.Name == columnName
                                    from attribute in modelProp.Attributes.OfType<ValidationAttribute>()
                                    where !attribute.IsValid(modelProp.GetValue(this))
                                    select attribute.ErrorMessage;

                foreach (var item in errormessages)
                {
                    errors.Append(item + "\n");
                }

                return errors.ToString();
            }
        }

    }
}
