using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using TriCheer.Phoenix.ModuleAdaptor;

namespace Tricheer.Phoneix.SimpleSequenceEditor.VM
{
    class ClassInfoVM : TreeViewItemViewModel
    {
        #region ctor
        public ClassInfoVM(IClassInfo ci, TreeViewItemViewModel parent) : base(parent, true)
        {
            this.ci = ci;
        }
        #endregion

        #region members
        IClassInfo ci;
        ObservableCollection<MethodInfoVM> methodInfoVMs = new ObservableCollection<MethodInfoVM>();
        #endregion

        #region props
        public string Name { get { return ci.Name; } }
        public ObservableCollection<MethodInfoVM> MethodInfoVMs {  get { return methodInfoVMs; } }
        public override bool IsSelected
        {
            get
            {
                return base.IsSelected;
            }
            set
            {
                base.IsSelected = value;
                App.Messenger.NotifyColleagues(Messages.Class_SelectionChanged, this);
            }
        }
        #endregion

        #region methods
        protected override void LoadChildren()
        {
            if (ci == null)
            {
                return;
            }
            foreach (IMethodInfo mi in ci.Methods)
            {
                //this.methodInfoVMs.Add(new MethodInfoVM(mi, this));
                base.Children.Add(new MethodInfoVM(mi, this));
            }
            //RaisePropertyChanged("MethodInfoVMs");
        }
        #endregion
    }
}
