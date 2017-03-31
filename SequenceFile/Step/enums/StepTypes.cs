using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TriCheer.Phoenix.SeqManager.SeqFile
{
    public enum StepTypes
    {
        None,
        Label,
        Action,
        PassOrFailTest,
        NumbericTest,
        MultiNumbericTest,
        StringValueTest,
    }
}
