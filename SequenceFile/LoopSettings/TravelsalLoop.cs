using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TriCheer.Phoenix.SequenceFile
{
    class TravelsalLoop : ILoopSettings
    {
        #region ctor
        public TravelsalLoop()
        {
            this.Name = "TravelsalLoop";
            this.LoopVariables = new List<Variable>();
        }
        #endregion

        public string Name { get; set; }

        public LoopTypes LoopType
        {
            get
            {
                return LoopTypes.Travelsal;
            }
        }
        
        public List<Variable> LoopVariables
        {
            get;
        }
    }
}
