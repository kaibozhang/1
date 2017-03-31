using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TriCheer.Phoenix.ModuleAdaptor
{
    public interface IParameterInfo
    {
        string Name { get; }
        Type Type { get; }
        object Value { get; set; }
        bool IsIn { get; }
        bool IsOut { get; }
        bool IsOpt { get; }
        object DefaultValue { get; }
    }
}
