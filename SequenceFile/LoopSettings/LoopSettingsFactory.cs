using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TriCheer.Phoenix.SeqManager.SeqFile
{
    public class LoopSettingsFactory
    {
        public static ILoopSettings CreateLoopSetting(LoopTypes loopType)
        {
            ILoopSettings loopSetting;
            switch(loopType)
            {
                case LoopTypes.None:
                    loopSetting = new NoneLoop();
                    break;
                case LoopTypes.Travelsal:
                    loopSetting = new TravelsalLoop();
                    break;
                case LoopTypes.CountPass:
                    loopSetting = new CountPassLoop();
                    break;
                default:
                    loopSetting = new NoneLoop();
                    break;
            }
            return loopSetting;
        }
    }
}
