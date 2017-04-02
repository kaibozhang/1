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
        }

        #endregion



        #region members
        ISequenceFile seqFile;
        ObservableCollection<SequenceVM> seqVMs = new ObservableCollection<SequenceVM>();
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
        #endregion

        #region callbacks

        #endregion

        #region public methods
        public void AddXttFile(string filePath)
        {
            try
            {
                seqFile.LoadXtt(filePath);
            }
            catch (Exception)
            {

                throw;
            }
            LoadChildren();
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


        #endregion
    }
}
