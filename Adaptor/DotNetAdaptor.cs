using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TriCheer.Phoenix.Adaptor
{
    class DotNetAdaptor : IAdaptor
    {
        #region ctor
        public DotNetAdaptor()
        {
            this.TestModuleName = string.Empty;
            this.MethodName = string.Empty;
            this.Parameters = new List<IParameter>();
        }
        #endregion

        public string TestModuleName
        {
            get; set;
        }
        public string MethodName
        {
            get;set;
        }

        public List<IParameter> Parameters
        {
            get;set;
        }
    }
}
