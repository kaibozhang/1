using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MvvmFoundation.Wpf;
using TriCheer.Phoenix.SeqManager.SeqFile;

namespace Tricheer.Phoneix.SimpleSequenceEditor.VM
{
    class TestItemVM : ObservableObject
    {
        #region ctor
        public TestItemVM(ITestItem ti)
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
        
        #endregion
    }
}
