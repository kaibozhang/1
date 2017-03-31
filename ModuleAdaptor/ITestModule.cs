using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TriCheer.Phoenix.ModuleAdaptor
{
    public interface ITestModule
    {
        string Name { get; }
        List<IClassInfo> ClassInfos { get; }
    }
}
