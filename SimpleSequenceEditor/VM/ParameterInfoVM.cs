using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TriCheer.Phoenix.ModuleAdaptor;

namespace Tricheer.Phoneix.SimpleSequenceEditor.VM
{
    class ParameterInfoVM : TreeViewItemViewModel
    {
        #region ctor
        public ParameterInfoVM(IParameterInfo pi, TreeViewItemViewModel parent) : base(parent, true)
        {
            this.pi = pi;
        }
        #endregion

        #region members
        IParameterInfo pi;
        #endregion

        #region props
        public string Name { get { return pi.Name; } }
        public string Type { get { return pi.Type.ToString(); } }
        public string Value
        {
            get { return pi.Value.ToString(); }
            set { pi.Value = value;RaisePropertyChanged("Value"); }
        }
        public string IsIn { get { return pi.IsIn.ToString(); } }
        public string IsOut { get { return pi.IsOut.ToString(); } }
        public string IsOpt { get { return pi.IsOpt.ToString(); } }
        #endregion

        #region methods
        #endregion
    }
}
