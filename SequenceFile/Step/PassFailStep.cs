using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TriCheer.Phoenix.SeqManager.SeqFile
{
    class PassFailStep : BaseStep
    {
        public override StepTypes StepType
        {
            get
            {
                return StepTypes.PassOrFailTest;
            }
        }
    }
}
