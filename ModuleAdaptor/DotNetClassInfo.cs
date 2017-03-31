using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace TriCheer.Phoenix.ModuleAdaptor
{
    class DotNetClassInfo : IClassInfo
    {
        #region ctor
        public DotNetClassInfo(Type t)
        {
            this.t = t;
            LoadMethods();
        }
        #endregion

        #region members
        Type t;
        List<IMethodInfo> mis = new List<IMethodInfo>();
        #endregion

        #region props
        public string Name
        {
            get
            {
                return t.Name;
            }
        }

        public List<IMethodInfo> Methods
        {
            get
            {
                return mis;
            }
        }
        #endregion

        #region methods
        void LoadMethods()
        {
            MethodInfo[] methods = t.GetMethods(Options.OutputMethodFlags);
            foreach (MethodInfo mi in methods)
            {
                this.mis.Add(new DotNetMethodInfo(mi));
            }
        }
        #endregion

    }
}
