using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MvvmFoundation.Wpf;

namespace Tricheer.Phoneix.SimpleSequenceEditor.VM
{
    class TestItemSettingsPanelVM : ObservableObject
    {
        #region ctor
        private TestItemSettingsPanelVM()
        {
            App.Messenger.Register<TestItemVM>(Messages.TestItem_SelectionChanged, OnTestItemChanged);
        }
        static TestItemSettingsPanelVM instance = new TestItemSettingsPanelVM();
        public static TestItemSettingsPanelVM Instance {  get { return instance; } }
        #endregion

        #region members
        TestItemVM tiVM;
        #endregion

        #region props
        public TestItemVM TestItemVM
        {
            get { return this.tiVM; }
            set { this.tiVM = value; RaisePropertyChanged("TestItemVM"); }
        }
        #endregion

        #region callbacks
        void OnTestItemChanged(TestItemVM tiVM)
        {
            this.TestItemVM = tiVM;
        }
        #endregion
    }
}
