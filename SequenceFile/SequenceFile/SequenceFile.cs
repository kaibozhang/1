using System;
using System.Collections.Generic;
using System.IO;
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

        #region method impl
        public void LoadXtt(string filePath)
        {
            ISequence seq = SequenceFactory.CreateSequence(SequenceTypes.XTT);
            seq.Name = Path.GetFileNameWithoutExtension(filePath);
            QSPR3xttParse.QSPR3XTT m_xttParser = new QSPR3xttParse.QSPR3XTT();
            try
            {
                if (m_xttParser.LoadRFCalXTT(filePath))
                {
                    for (int testIndex = 0; testIndex < m_xttParser.GetNumOfTests(); testIndex++)
                    {
                        string testName = m_xttParser.GetTestName(testIndex);
                        string realName = m_xttParser.GetRealName(testIndex);

                        IStep step = StepFactory.CreateStep(StepTypes.XttStep);
                        step.Name = testName;

                        seq.Children.Add(step);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            this.seqs.Add(seq);
        }
        #endregion

    }
}
