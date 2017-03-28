using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TriCheer.Phoenix.SeqManager.SeqFile
{
    public interface ISequence : ITestItem
    {
        SequenceTypes SequenceType { get; }
    }
}
