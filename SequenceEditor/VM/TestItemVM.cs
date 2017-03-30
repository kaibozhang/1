using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MVVM.VMBase;
using TriCheer.Phoenix.SeqManager.SeqFile;
using System.Collections.ObjectModel;

namespace TriCheer.Phoenix.SeqEditor
{
    public class TestItemVM : ViewModelBase
    {
        #region ctor
        public TestItemVM(ITestItem testItem)
        {
            this.item = testItem;
            LoadChilds();
        }
        #endregion

        #region members
        ITestItem item;
        ObservableCollection<TestItemVM> childVMs = new ObservableCollection<TestItemVM>();
        #endregion

        #region props
        public string Name
        {
            get { return item.Name; }
            set { item.Name = value; NotifyPropertyChanged("Name"); }
        }

        public string Description
        {
            get { return item.Description; }
            set { item.Description = value; NotifyPropertyChanged("Description"); }
        }
        public ObservableCollection<TestItemVM> ChildVMs
        {
            get { return childVMs; }
        }
        #endregion

        #region commands
        #endregion

        #region methods
        void LoadChilds()
        {
            foreach (ITestItem item in item.Childs)
            {
                childVMs.Add(new TestItemVM(item));
            }
            NotifyPropertyChanged("ChildVMs");
        }
        #endregion
    }
}
