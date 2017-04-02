using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TriCheer.Phoenix.SeqManager.SeqFile;

namespace Tricheer.Phoneix.SimpleSequenceEditor.VM
{
    class StepVM : BaseTestItemVM
    {
        #region ctor
        public StepVM(IStep step, SequenceVM parent) : base(parent, true)
        {

        }
        #endregion

        #region members
        IStep testItem;
        #endregion

        #region props
        public string Name
        {
            get { return testItem.Name; }
            set { testItem.Name = value; RaisePropertyChanged("Name"); }
        }

        public string Description
        {
            get { return testItem.Description; }
            set { testItem.Description = value; RaisePropertyChanged("Description"); }
        }

        public TestItemTypes ItemType
        {
            get { return testItem.TestItemType; }
        }

        public Array TestItemTypesArray
        {
            get { return Enum.GetValues(typeof(TestItemTypes)); }
        }

        public TestItemGroups TestItemGroup
        {
            get { return testItem.TestItemGroup; }
            set { testItem.TestItemGroup = value; RaisePropertyChanged("TestItemGroup"); }
        }

        public Array TestItemGroupsArray
        {
            get { return Enum.GetValues(typeof(TestItemGroups)); }
        }

        public StepTypes StepType
        {
            get { return testItem.StepType; }
        }

        public Array StepTypesArray
        {
            get { return Enum.GetValues(typeof(StepTypes)); }
        }

        public int TestTimeout
        {
            get { return testItem.TestTimeout; }
            set { testItem.TestTimeout = value; RaisePropertyChanged("TestTimeout"); }
        }

        public RunModes RunMode
        {
            get { return testItem.RunMode; }
            set { testItem.RunMode = value; RaisePropertyChanged("RunMode"); }
        }

        public Array RunmodesArray
        {
            get { return Enum.GetValues(typeof(RunModes)); }
        }

        public override bool IsSelected
        {
            get
            {
                return base.IsSelected;
            }

            set
            {
                base.IsSelected = value;
                App.Messenger.NotifyColleagues(Messages.TestItem_SelectionChanged, this);
            }
        }
        #endregion

        #region methods
        protected override void LoadChildren()
        {
            if (testItem == null)
            {
                return;
            }

            foreach (ITestItem item in testItem.Children)
            {
                base.Children.Add(new TestItemVM(item, this));
            }
        }
        #endregion
    }
}
