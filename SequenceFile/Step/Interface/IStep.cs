using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TriCheer.Phoenix.Adaptor;

namespace TriCheer.Phoenix.SequenceFile
{
    public interface IStep
    {
        string ID { get; set; }
        string Name { get; set; }
        StepRunModes RunMode { get; set; }
        StepTypes Type { get; set; }
        IAdaptor Adaptor { get; set; }
    }
}
