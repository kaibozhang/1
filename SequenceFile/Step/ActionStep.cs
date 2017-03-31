using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TriCheer.Phoenix.SeqManager.Adaptor;

namespace TriCheer.Phoenix.SeqManager.SeqFile
{
    public class ActionStep : BaseStep
    {
        #region ctor
        public ActionStep()
        {
            this.Name = "Action Step";
        }
        #endregion

        public override StepTypes StepType
        {
            get { return StepTypes.Action; }
        }
    }
}
