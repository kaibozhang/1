using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TriCheer.Phoenix.SeqManager.Adaptor;

namespace TriCheer.Phoenix.SeqManager.SeqFile
{
    class XttStep : BaseStep
    {
        #region ctor
        public XttStep() : base()
        {

        }
        #endregion
        public override StepTypes StepType
        {
            get
            {
                return StepTypes.XttStep;
            }
        }
    }
}
