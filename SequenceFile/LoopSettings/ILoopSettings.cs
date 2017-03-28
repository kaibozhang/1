using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TriCheer.Phoenix.SeqManager.SeqFile
{
    public interface ILoopSettings
    {
        string Name { get; set; }
        LoopTypes LoopType { get;}
    }
}
