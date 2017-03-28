using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TriCheer.Phoenix.SeqManager.SeqFile
{
    class NoneLoop : ILoopSettings
    {
        #region ctor
        public NoneLoop()
        {
            Name = "NoneLoop";
        }
        #endregion
        public string Name { get; set; }

        public LoopTypes LoopType
        {
            get { return LoopTypes.None; }
        }
    }
}
