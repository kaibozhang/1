using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TriCheer.Phoenix.SequenceFile
{
    class TravelsalLoop : ILoopSettings
    {
        public string Name { get; set; }

        public LoopTypes LoopType
        {
            get
            {
                return LoopTypes.Travelsal;
            }
        }

        List<Variable> loopVariables = new List<Variable>();
        public List<Variable> LoopVariables
        {
            get { return loopVariables; }
        }
    }
}
