using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace TriCheer.Phoenix.ModuleAdaptor
{
    class DotNetMethodInfo : IMethodInfo
    {
        #region ctor
        public DotNetMethodInfo(MethodInfo mi)
        {
            this.mi = mi;
            LoadParameters();
        }
        #endregion

        #region members
        MethodInfo mi;
        List<IParameterInfo> pis = new List<IParameterInfo>();
        #endregion

        #region props
        public string FullName
        {
            get
            {
                return GenerateFullName();
            }
        }
        public Type ReturnType
        {
            get
            {
                return mi.ReturnType;
            }
        }
        public List<IParameterInfo> Parameters
        {
            get
            {
                return pis;
            }
        }


        #endregion

        #region methods
        void LoadParameters()
        {
            ParameterInfo[] pis = mi.GetParameters();
            foreach (ParameterInfo pi in pis)
            {
                this.pis.Add(new DotNetParameterInfo(pi));
            }
        }

        string GenerateFullName()
        {
            // e.g: int Add(int x, int y)
            string head = string.Format("{0} {1}(", ReturnType.ToString(), mi.Name);
            string middle = string.Empty;
            foreach (IParameterInfo pi in pis)
            {
                middle += string.Format("{0} {1},", pi.Type.ToString(), pi.Name);
            }
            middle = middle.Substring(0, middle.Length - 1);
            return head + middle + ")";
        }
        #endregion
    }
}
