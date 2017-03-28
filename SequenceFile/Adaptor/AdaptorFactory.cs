using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TriCheer.Phoenix.SeqManager.Adaptor
{
    public class AdaptorFactory
    {
        public static IAdaptor CreateAdaptor(AdaptorTypes adaptorType)
        {
            IAdaptor adaptor;
            switch(adaptorType)
            {
                case AdaptorTypes.DotnetAdaptor:
                    adaptor = new DotNetAdaptor();
                    break;
                default:
                    adaptor = null;
                    break;
            }
            return adaptor;
        }
    }
}
