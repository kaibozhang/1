using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TriCheer.Phoenix.SequenceFile
{
    public class SequenceFile : ISequenceFile
    {
        #region ctor
        public SequenceFile()
        {
            this.Name = string.Empty;
            this.Description = string.Empty;
            this.Comment = string.Empty;
            this.MainSequence = SequenceFactory.CreateSequence(SequenceTypes.Normal);
            this.SubSequences = new List<ISequence>();
            this.Version = new SequenceFileVersionInfo();
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
