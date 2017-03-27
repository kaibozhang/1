using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TriCheer.Phoenix.SequenceFile
{
    public class NormalSequence : ISequence
    {
        #region ctor
        public NormalSequence()
        {
            this.Name = string.Empty;
            this.Description = string.Empty;
            this.TestItemGroup = TestItemGroups.Main;
            this.TestItemType = TestItemTypes.Sequence;
            this.Childs = new List<ITestItem>();
            this.Variables = new List<Variable>();

            this.BreakPoint = false;
            this.EnableLogging = true;

            this.TestTimeout = 60000;
            this.LoopSettings = LoopSettingsFactory.CreateLoopSetting(LoopTypes.None);
            this.RunMode = RunModes.Normal;
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

        public List<ITestItem> Childs
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

        public ILoopSettings LoopSettings
        {
            get;set;
        }

        public RunModes RunMode
        {
            get;set;
        }


        #endregion

    }
}
