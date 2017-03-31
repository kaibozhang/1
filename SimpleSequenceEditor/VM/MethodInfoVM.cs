using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using TriCheer.Phoenix.ModuleAdaptor;

namespace Tricheer.Phoneix.SimpleSequenceEditor.VM
{
    class MethodInfoVM : TreeViewItemViewModel
    {
        #region ctor
        public MethodInfoVM(IMethodInfo mi, TreeViewItemViewModel parent) : base(parent, true)
        {
            this.mi = mi;
        }
        #endregion

        #region members
        IMethodInfo mi;
        ObservableCollection<ParameterInfoVM> paramsInfoVMs = new ObservableCollection<ParameterInfoVM>();
        #endregion

        #region props
        public string FullName { get { return mi.FullName; } }
        public string ReturnType { get { return mi.ReturnType.ToString(); } }
        public ObservableCollection<ParameterInfoVM> ParameterInfoVMs { get { return paramsInfoVMs; } }
        #endregion

        #region methods
        protected override void LoadChildren()
        {
            if (mi == null)
            {
                return;
            }

            foreach (IParameterInfo pi in mi.Parameters)
            {
                //paramsInfoVMs.Add(new ParameterInfoVM(pi, this));
                base.Children.Add(new ParameterInfoVM(pi, this));
            }
        }
        #endregion
    }
}
