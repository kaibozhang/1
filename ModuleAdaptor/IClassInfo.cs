using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TriCheer.Phoenix.ModuleAdaptor
{
    public interface IClassInfo
    {
        string Name { get; }
        List<IMethodInfo> Methods { get; }
    }
}
