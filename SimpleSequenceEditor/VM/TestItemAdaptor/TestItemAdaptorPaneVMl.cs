using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MvvmFoundation.Wpf;

namespace Tricheer.Phoneix.SimpleSequenceEditor.VM
{
    class TestItemAdaptorPanelVM : ObservableObject
    {
        #region ctor
        private TestItemAdaptorPanelVM()
        {
            App.Messenger.Register<TestItemVM>(Messages.TestItem_SelectionChanged, OnTestItemChanged);
        }
        static TestItemAdaptorPanelVM instance = new TestItemAdaptorPanelVM();
        public static TestItemAdaptorPanelVM Instance { get { return instance; } }
        #endregion

        #region members
        TestItemAdaptorVM tiaVM;
        #endregion

        #region props
        public TestItemAdaptorVM TestItemAdaptorVM
        {
            get { return tiaVM; }
            set { tiaVM = value; RaisePropertyChanged("TestItemAdaptorVM"); }
        }
        #endregion

        #region callbacks
        void OnTestItemChanged(TestItemVM tiVM)
        {

        }
        #endregion
    }
}
