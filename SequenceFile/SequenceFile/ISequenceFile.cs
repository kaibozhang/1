using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TriCheer.Phoenix.SeqManager.SeqFile
{
    public interface ISequenceFile
    {
        string Name { get; set; }
        string Description { get; set; }
        string Comment { get; set; }
        List<ISequence> Sequences { get; set; }
        SequenceFileVersionInfo Version { get; set; }

        void LoadXtt(string filePath);
    }
}
