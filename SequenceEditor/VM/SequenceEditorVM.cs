using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TriCheer.Phoenix.SeqManager.SeqFile;
using MVVM.VMBase;
using System.Windows.Input;
using System.Collections.ObjectModel;

namespace TriCheer.Phoenix.SeqEditor
{
    public class SequenceEditorVM : ViewModelBase
    {
        #region members
        ObservableCollection<SequenceFileVM> seqFileVMs = new ObservableCollection<SequenceFileVM>();
        SequenceFileVM activeSeqFileViewModel = null;
        StepSettingsVM stepSettingsVM = new StepSettingsVM();
        ToolViewModel[] stepSettingVMs = null;
        const string seqFileExtName = ".xml";
        #endregion

        #region ctor for singleTon
        static SequenceEditorVM instance;
        private SequenceEditorVM()
        {
        }
        public static SequenceEditorVM Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SequenceEditorVM();
                }
                return instance;
            }
        }
        #endregion

        #region props
        public ObservableCollection<SequenceFileVM> SequenceFileVMs
        {
            get { return seqFileVMs; }
        }

        public SequenceFileVM ActiveSequenceFileVM
        {
            get { return activeSeqFileViewModel; }
            set
            {
                if (activeSeqFileViewModel != value)
                {
                    activeSeqFileViewModel = value;
                    NotifyPropertyChanged("ActiveSequenceFileVM");
                }
            }
        }

        public StepSettingsVM StepSettingsVM
        {
            get { return stepSettingsVM; }
        }
        public IEnumerable<ToolViewModel> StepSettingsViewModels
        {
            get
            {
                if (stepSettingVMs == null)
                    stepSettingVMs = new ToolViewModel[] { StepSettingsVM };
                return stepSettingVMs;
            }
        }
        #endregion

        #region commonds
        private RelayCommand createSeqFileCmd = null;
        public ICommand CreateSeqFileCMD
        {
            get
            {
                if (createSeqFileCmd == null)
                {
                    createSeqFileCmd = new RelayCommand(OnCreateSeqFile, CanCreateSeqFile);
                }
                return createSeqFileCmd;
            }
        }
        private void OnCreateSeqFile()
        {
            ISequenceFile seqFile = SequenceFileFactory.CreateSequenceFile();
            seqFile.Name = "NewSequenceFile";
            this.seqFileVMs.Add(new SequenceFileVM(seqFile));
            NotifyPropertyChanged("SequenceFileVMs");
        }
        private bool CanCreateSeqFile()
        {
            return true;
        }

        #endregion
    }
}
