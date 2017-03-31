using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace TriCheer.Phoenix.ModuleAdaptor
{
    class DotNetParameterInfo : IParameterInfo
    {
        #region ctor
        public DotNetParameterInfo(ParameterInfo pi)
        {
            this.pi = pi;
        }
        #endregion

        #region members
        ParameterInfo pi;
        object value = null;
        #endregion

        #region props
        public string Name
        {
            get
            {
                return pi.Name;
            }
        }
        public Type Type
        {
            get
            {
                return pi.ParameterType;
            }
        }
        public object Value
        {
            get
            {
                return value;
            }

            set
            {
                this.value = value;
            }
        }
        public bool IsIn
        {
            get
            {
                return pi.IsIn;
            }
        }
        public bool IsOut
        {
            get
            {
                return pi.IsOut;
            }
        }
        public bool IsOpt
        {
            get
            {
                return pi.IsOptional;
            }
        }
        public object DefaultValue
        {
            get
            {
                return pi.DefaultValue;
            }
        }
        #endregion

       


    }
}
