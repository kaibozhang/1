﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TriCheer.Phoenix.SequenceFile
{
    public interface ISequenceFile
    {
        string Name { get; set; }
        string Description { get; set; }
        string Comment { get; set; }
        SequenceFileVersionInfo Version { get; set; }
        ISequence MainSequence { get; set; }
        List<ISequence> SubSequences { get; set; }
    }
}