﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TriCheer.Phoenix.SequenceFile
{
    class NoneLoop : ILoopSettings
    {
        public string Name { get; set; }

        public LoopTypes LoopType
        {
            get { return LoopTypes.None; }
        }
    }
}