using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TriCheer.Phoenix.SeqManager.SeqFile
{
    public class NormalSequence : ISequence
    {
        #region ctor
        public NormalSequence()
        {
            Name = string.Empty;
            Description = string.Empty;
            TestItemGroup = TestItemGroups.Main;
            TestItemType = TestItemTypes.Sequence;
            Children = new List<ITestItem>();
            Variables = new List<Variable>();

            BreakPoint = false;
            EnableLogging = true;

            TestTimeout = 60000;
            LoopSettings = LoopSettingsFactory.CreateLoopSetting(LoopTypes.None);
            RunMode = RunModes.Normal;
        }
        #endregion

        #region attributes
        public string Name
        {
            get;set;
        }

        public string Description
        {
            get;set;
        }

        public SequenceTypes SequenceType
        {
            get { return SequenceTypes.Normal; }
        }

        public TestItemGroups TestItemGroup
        {
            get;set;
        }

        public TestItemTypes TestItemType
        {
            get;set;
        }

        public StepTypes StepType
        {
            get
            {
                return StepTypes.None;
            }
        }

        public List<ITestItem> Children
        {
            get;set;
        }

        public List<Variable> Variables
        {
            get;set;
        }
        #endregion

        #region debug
        public bool BreakPoint
        {
            get;set;
        }

        public bool EnableLogging
        {
            get;set;
        }
        #endregion

        #region execution
        public int TestTimeout
        {
            get; set;
        }
        public RunModes RunMode
        {
            get; set;
        }
        public ILoopSettings LoopSettings
        {
            get;set;
        }
        #endregion

    }
}
