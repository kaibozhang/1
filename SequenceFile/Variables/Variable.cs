using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TriCheer.Phoenix.SequenceFile
{
    public class Variable
    {
        #region ctor
        public Variable()
        {
            this.Name = string.Empty;
            this.Description = string.Empty;
            this.Value = string.Empty;
        }
        #endregion

        #region prop
        public string Name { get; set; }
        public string Description { get; set; }
        public string Value { get; set; }
        #endregion
    }
}
