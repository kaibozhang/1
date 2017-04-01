using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TriCheer.Phoenix.SeqManager.SeqFile
{
    class XttSequence : ISequence
    {
        #region ctor
        public XttSequence()
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

        #region members
        #endregion

        #region props
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
            get { return SequenceTypes.XTT; }
        }
        public TestItemGroups TestItemGroup
        {
            get; set;
        }
        public TestItemTypes TestItemType
        {
            get; set;
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
            get; set;
        }
        public List<Variable> Variables
        {
            get; set;
        }
        #region debug
        public bool BreakPoint
        {
            get; set;
        }

        public bool EnableLogging
        {
            get; set;
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
            get; set;
        }
        #endregion
        #endregion
    }
}
