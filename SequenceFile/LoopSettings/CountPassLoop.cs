using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TriCheer.Phoenix.SequenceFile
{
    public class CountPassLoop : ILoopSettings
    {
        #region ctor
        public CountPassLoop()
        {
            this.Name = "CountPass Loop";
            this.CountPassNumber = 1;
        }
        #endregion

        public string Name
        {
            get;set;
        }

        public int CountPassNumber
        {
            get;set;
        }

        public LoopTypes LoopType
        {
            get
            {
                return LoopTypes.CountPass;
            }
        }
    }
}
