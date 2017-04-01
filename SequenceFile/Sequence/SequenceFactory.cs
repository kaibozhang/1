using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TriCheer.Phoenix.SeqManager.SeqFile
{
    public class SequenceFactory
    {
        public static ISequence CreateSequence(SequenceTypes sequenceType)
        {
            ISequence seq;
            switch(sequenceType)
            {
                case SequenceTypes.Normal:
                    seq = new NormalSequence();
                    break;
                case SequenceTypes.XTT:
                    seq = new XttSequence();
                    break;
                default:
                    seq = new NormalSequence();
                    break;
            }
            return seq;
        }
    }
}
