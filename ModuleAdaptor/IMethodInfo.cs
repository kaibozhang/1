using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TriCheer.Phoenix.ModuleAdaptor
{
    public interface IMethodInfo
    {
        string FullName { get; }
        Type ReturnType { get; }
        List<IParameterInfo> Parameters { get; }
    }
}
