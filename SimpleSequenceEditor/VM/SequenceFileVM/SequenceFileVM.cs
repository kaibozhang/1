using MvvmFoundation.Wpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using TriCheer.Phoenix.SeqManager.SeqFile;

namespace Tricheer.Phoneix.SimpleSequenceEditor.VM
{
    class SequenceFileVM : ObservableObject
    {
        #region ctor
        public SequenceFileVM(ISequenceFile seqFile)
        {
            this.seqFile = seqFile;
            LoadChildren();
            App.Messenger.Register<TestItemVM>(Messages.TestItem_SelectionChanged, OnTestItemSelectionChanged);
            App.Messenger.Register<SequenceVM>(Messages.Sequence_SelectionChanged, OnSequenceSelectionChanged);
        }

        #endregion

        #region members
        ISequenceFile seqFile;
        ObservableCollection<SequenceVM> seqVMs = new ObservableCollection<SequenceVM>();
        SequenceVM activeSequenceVM;
        TestItemVM activeTestItemVM;
        #endregion

        #region props
        public string Name
        {
            get { return seqFile.Name; }
        }

        public ObservableCollection<SequenceVM> SequenceVMs
        {
            get { return seqVMs; }
        }

        public SequenceVM ActiveSequenceVM
        {
            get { return activeSequenceVM; }
        }
        public TestItemVM ActiveTestItemVM
        {
            get { return activeTestItemVM; }
        }
        #endregion

        #region methods
        void LoadChildren()
        {
            if (seqFile == null)
            {
                return;
            }
            foreach (ISequence seq in seqFile.Sequences)
            {
                SequenceVM seqVM = new SequenceVM(seq);
                seqVM.IsExpanded = true;
                seqVM.IsChecked = true;
                seqVMs.Add(seqVM);
            }
            //RaisePropertyChanged("ChildrenVMs");
        }

        void OnTestItemSelectionChanged(object parameter)
        {
            TestItemVM tiVM = parameter as TestItemVM;
            if (tiVM.IsSelected)
            {
                activeTestItemVM = tiVM;
            }
        }

        void OnSequenceSelectionChanged(object parameter)
        {
            SequenceVM seqVM = parameter as SequenceVM;
            if (seqVM.IsSelected)
            {
                activeSequenceVM = seqVM;
            }
        }
        #endregion
    }
}
