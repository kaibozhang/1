using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TriCheer.Phoenix.SeqManager.SeqFile
{
    public class StepFactory
    {
        public static IStep CreateStep(StepTypes stepType)
        {
            IStep step = null;
            switch(stepType)
            {
                case StepTypes.Action:
                    step = new ActionStep();
                    break;
                case StepTypes.PassOrFailTest:
                    step = new PassFailStep();
                    break;
                case StepTypes.XttStep:
                    step = new XttStep();
                    break;
                default:
                    step = null;
                    break;
            }
            return step;
        }
    }
}
