using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TriCheer.Phoenix.Adaptor
{
    class DotNetParameter : IParameter
    {
        #region ctor
        public DotNetParameter()
        {
            this.Name = string.Empty;
            this.Description = string.Empty;
            this.Value = string.Empty;
            this.IsIn = true;
            this.IsOut = false;
            this.IsOptional = false;
        }
        #endregion

        public string Name
        {
            get; set;
        }
        public string Description
        {
            get;set;
        }
        public string Value
        {
            get; set;
        }

        public bool IsIn
        {
            get; set;
        }
        public bool IsOut
        {
            get; set;
        }
        public bool IsOptional
        {
            get; set;
        }
    }
}
