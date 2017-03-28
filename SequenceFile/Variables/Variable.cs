using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TriCheer.Phoenix.SeqManager.SeqFile
{
    public class Variable
    {
        #region ctor
        public Variable()
        {
            Name = string.Empty;
            Description = string.Empty;
            Value = string.Empty;
        }
        #endregion

        #region prop
        public string Name { get; set; }
        public string Description { get; set; }
        public string Value { get; set; }
        #endregion
    }
}
