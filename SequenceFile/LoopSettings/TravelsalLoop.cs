using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TriCheer.Phoenix.SeqManager.SeqFile
{
    class TravelsalLoop : ILoopSettings
    {
        #region ctor
        public TravelsalLoop()
        {
            Name = "TravelsalLoop";
            LoopVariables = new List<Variable>();
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
