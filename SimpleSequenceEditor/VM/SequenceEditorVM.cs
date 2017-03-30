using MvvmFoundation.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace Tricheer.Phoneix.SimpleSequenceEditor.VM
{
    class SequenceEditorVM : ObservableObject
    {
        #region ctor for singleton
        static SequenceEditorVM instance = new SequenceEditorVM();
        private SequenceEditorVM() { }
        public static SequenceEditorVM Instance { get { return instance; } }
        #endregion

        #region members
        #endregion

        #region props
        #endregion

        #region commands
        RelayCommand createSeqFileCmd = null;
        public ICommand CreateSeqFileCmd
        {
            get
            {
                if (createSeqFileCmd == null)
                {
                    createSeqFileCmd = new RelayCommand(OnCreateSeqFile);
                }
                return createSeqFileCmd;
            }
        }
        void OnCreateSeqFile()
        {

        }
        #endregion
    }
}
