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
            MainSequence = SequenceFactory.CreateSequence(SequenceTypes.Normal);
            SubSequences = new List<ISequence>();
            Version = new SequenceFileVersionInfo();
        }
        #endregion

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

        public ISequence MainSequence
        {
            get;set;
        }

        public List<ISequence> SubSequences
        {
            get;set;
        }

    }
}
