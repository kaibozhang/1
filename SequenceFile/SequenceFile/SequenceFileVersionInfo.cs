using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TriCheer.Phoenix.SeqManager.SeqFile
{
    public class SequenceFileVersionInfo
    {
        #region members
        string marjorVersion;
        string minorVersion;
        string subVersion;
        string revision;
        #endregion

        #region ctor
        public SequenceFileVersionInfo()
        {
            marjorVersion = "0";
            minorVersion = "0";
            subVersion = "0";
            revision = "0";
        }
        #endregion

        #region props

        public string MarjorVersion
        {
            get { return marjorVersion; }
            set { marjorVersion = value; }
        }
        public string MinorVersion
        {
            get { return minorVersion; }
            set { minorVersion = value; }
        }
        public string SubVersion
        {
            get { return subVersion; }
            set { subVersion = value; }
        }
        public string Resivion
        {
            get { return revision; }
            set { revision = value; }
        }
        #endregion

    }
}
