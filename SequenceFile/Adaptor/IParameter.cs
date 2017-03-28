using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TriCheer.Phoenix.SeqManager.Adaptor
{
    public interface IParameter
    {
        string Name { get; set; }
        string Description { get; set; }
        string Value { get; set; }
        bool IsIn { get; set; }
        bool IsOut { get; set; }
        bool IsOptional { get; set; }
    }
}
