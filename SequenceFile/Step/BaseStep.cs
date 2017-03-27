using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TriCheer.Phoenix.Adaptor;

namespace TriCheer.Phoenix.SequenceFile
{
    public abstract class BaseStep : IStep
    {
        #region ctor
        public BaseStep()
        {
            this.Name = string.Empty;
            this.Description = string.Empty;
            this.TestItemGroup = TestItemGroups.Main;
            this.Childs = new List<ITestItem>();
            this.Variables = new List<Variable>();

            this.BreakPoint = false;
            this.EnableLogging = true;

            this.TestTimeout = 30000;
            this.RunMode = RunModes.Normal;
            this.LoopSettings = LoopSettingsFactory.CreateLoopSetting(LoopTypes.None);
        }
        #endregion

        #region attribute
        public string Name
        {
            get;set;
        }
        public string Description
        {
            get;set;
        }

        public abstract StepTypes Type
        {
            get;
        }

        public TestItemGroups TestItemGroup
        {
            get;set;
        }

        public TestItemTypes TestItemType
        {
            get { return TestItemTypes.Step; }
        }

        public IAdaptor Adaptor
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
            get;set;
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
