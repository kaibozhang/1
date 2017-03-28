using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TriCheer.Phoenix.SeqManager.Adaptor
{
    public interface IAdaptor
    {
        string TestModuleName { get; set; }
        string MethodName { get; set; }
        List<IParameter> Parameters { get; set; }
    }
}
