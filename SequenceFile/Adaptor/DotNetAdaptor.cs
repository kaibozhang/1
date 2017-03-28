using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TriCheer.Phoenix.SeqManager.Adaptor
{
    class DotNetAdaptor : IAdaptor
    {
        #region ctor
        public DotNetAdaptor()
        {
            TestModuleName = string.Empty;
            MethodName = string.Empty;
            Parameters = new List<IParameter>();
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
