using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TriCheer.Phoenix.Adaptor;

namespace TriCheer.Phoenix.SequenceFile
{
    public interface IStep : ITestItem
    {
        StepTypes Type { get; }
        IAdaptor Adaptor { get; set; }
    }
}
