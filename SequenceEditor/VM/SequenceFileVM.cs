using MVVM.VMBase;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using TriCheer.Phoenix.SeqManager.SeqFile;

namespace TriCheer.Phoenix.SeqEditor
{
    public class SequenceFileVM : PaneViewModel
    {
        #region ctor
        public SequenceFileVM()
        {

        }

        public SequenceFileVM(ISequenceFile seqFile)
        {
            this.seqFile = seqFile;
            this.Title = seqFile.Name;
        }
        #endregion

        #region members
        ObservableCollection<TestItemVM> testItemVMs = new ObservableCollection<TestItemVM>();
        TestItemVM activeTestItemVM = null;
        bool _isDirty = false;
        ISequenceFile seqFile;
        #endregion

        #region props
        public ObservableCollection<TestItemVM> TestItemVMs
        {
            get { return testItemVMs; }
        }
        public TestItemVM ActiveTestItemVM
        {
            get { return activeTestItemVM; }
            set
            {
                if (activeTestItemVM != value)
                {
                    activeTestItemVM = value;
                    NotifyPropertyChanged("ActiveTestItemVM");
                }
            }
        }
        public bool IsDirty
        {
            get { return _isDirty; }
            set
            {
                if (_isDirty != value)
                {
                    _isDirty = value;
                    NotifyPropertyChanged("IsDirty");
                    NotifyPropertyChanged("Name");
                    this.Title = this.Name;
                }
            }
        }
        public string Name
        {
            get { return seqFile.Name + (IsDirty ? "*" : ""); }
            set
            {
                if (seqFile.Name != value)
                {
                    seqFile.Name = value;
                    IsDirty = true;
                    NotifyPropertyChanged("Name");
                }
            }
        }
        #endregion

        #region commands
        private RelayCommand addActionStepCmd = null;
        public ICommand AddActionStepCmd
        {
            get
            {
                if (addActionStepCmd == null)
                {
                    addActionStepCmd = new RelayCommand(OnAddActionStep, CanAddActionStep);
                }
                return addActionStepCmd;
            }
        }
        private void OnAddActionStep()
        {
            IStep step = StepFactory.CreateStep(StepTypes.Action);
            AddStepVM(step);
        }
        private bool CanAddActionStep()
        {
            return true;
        }

        private RelayCommand addPassFailTestStepCmd = null;
        public ICommand AddPassFailTestStepCmd
        {
            get
            {
                if (addPassFailTestStepCmd == null)
                {
                    addPassFailTestStepCmd = new RelayCommand(OnAddPassFailTestStep, CanAddPassFailTestStep);
                }
                return addPassFailTestStepCmd;
            }
        }
        private void OnAddPassFailTestStep()
        {
            IStep step = StepFactory.CreateStep(StepTypes.PassOrFailTest);
            AddStepVM(step);
        }
        private bool CanAddPassFailTestStep()
        {
            return true;
        }

        void AddStepVM(IStep step)
        {
            this.testItemVMs.Add(new TestItemVM(step));
            this.IsDirty = true;
            NotifyPropertyChanged("TestItemVMs");
        }
        #endregion
    }


}
