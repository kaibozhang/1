using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TriCheer.Phoenix.SeqManager.Adaptor;

namespace TriCheer.Phoenix.SeqManager.SeqFile
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
