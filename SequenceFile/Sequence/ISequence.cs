using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TriCheer.Phoenix.SequenceFile
{
    public interface ISequence : ITestItem
    {
        SequenceTypes SequenceType { get; }
    }
}
