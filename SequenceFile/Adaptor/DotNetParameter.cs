using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TriCheer.Phoenix.SeqManager.Adaptor
{
    public class DotNetParameter : IParameter
    {
        #region ctor
        public DotNetParameter()
        {
            Name = string.Empty;
            Description = string.Empty;
            Value = string.Empty;
            IsIn = true;
            IsOut = false;
            IsOptional = false;
        }

        public DotNetParameter(string name) : this()
        {
            Name = name;
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
