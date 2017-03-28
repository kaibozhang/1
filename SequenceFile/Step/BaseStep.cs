using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TriCheer.Phoenix.SeqManager.Adaptor;

namespace TriCheer.Phoenix.SeqManager.SeqFile
{
    public abstract class BaseStep : IStep
    {
        #region ctor
        public BaseStep()
        {
            Name = string.Empty;
            Description = string.Empty;
            TestItemGroup = TestItemGroups.Main;
            Childs = new List<ITestItem>();
            Variables = new List<Variable>();
            Adaptor = AdaptorFactory.CreateAdaptor(AdaptorTypes.DotnetAdaptor);

            BreakPoint = false;
            EnableLogging = true;

            TestTimeout = 30000;
            RunMode = RunModes.Normal;
            LoopSettings = LoopSettingsFactory.CreateLoopSetting(LoopTypes.None);
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
