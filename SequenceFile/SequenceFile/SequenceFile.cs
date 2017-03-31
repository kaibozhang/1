using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TriCheer.Phoenix.SeqManager.SeqFile
{
    public class SequenceFile : ISequenceFile
    {
        #region ctor
        public SequenceFile()
        {
            Name = string.Empty;
            Description = string.Empty;
            Comment = string.Empty;
            Version = new SequenceFileVersionInfo();
        }
        #endregion

        #region members
        List<ISequence> seqs = new List<ISequence>();
        #endregion

        #region props
        public string Name
        {
            get; set;
        }
        public string Description
        {
            get; set;
        }
        public string Comment
        {
            get;set;
        }

        public SequenceFileVersionInfo Version
        {
            get; set;
        }

        public List<ISequence> Sequences
        {
            get { return seqs; }
            set { seqs = value; }
        }
        #endregion

        // 
        //         public List<ISequence> SubSequences
        //         {
        //             get;set;
        //         }

    }
}
