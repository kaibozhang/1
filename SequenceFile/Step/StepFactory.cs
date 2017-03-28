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

                default:
                    step = null;
                    break;
            }
            return step;
        }
    }
}
