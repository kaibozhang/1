using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TriCheer.Phoenix.Adaptor;

namespace TriCheer.Phoenix.SequenceFile
{
    public class ActionStep : BaseStep
    {
        public override StepTypes Type
        {
            get
            {
                return StepTypes.Action;
            }
        }
    }
}
