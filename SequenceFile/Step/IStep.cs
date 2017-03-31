using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TriCheer.Phoenix.SeqManager.Adaptor;

namespace TriCheer.Phoenix.SeqManager.SeqFile
{
    public interface IStep : ITestItem
    {
        IAdaptor Adaptor { get; set; }
    }
}
