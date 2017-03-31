using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MvvmFoundation.Wpf;
using TriCheer.Phoenix.SeqManager.SeqFile;

namespace Tricheer.Phoneix.SimpleSequenceEditor.VM
{
    class TestItemVM : TreeViewItemViewModel
    {
        #region ctor
        public TestItemVM(ITestItem ti, SequenceVM parent) : base(parent, true)
        {
            testItem = ti;
        }

        public TestItemVM(ITestItem ti, TestItemVM parent) : base(parent, true)
        {
            testItem = ti;
        }
        #endregion

        #region members
        ITestItem testItem;
        #endregion

        #region props
        public string Name
        {
            get { return testItem.Name; }
            set { testItem.Name = value;  RaisePropertyChanged("Name"); }
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
