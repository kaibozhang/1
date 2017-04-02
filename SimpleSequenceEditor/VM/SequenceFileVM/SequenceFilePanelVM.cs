using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MvvmFoundation.Wpf;

namespace Tricheer.Phoneix.SimpleSequenceEditor.VM
{
    class SequenceFilePanelVM : ObservableObject
    {
        #region ctor
        private SequenceFilePanelVM()
        {

        }
        static SequenceFilePanelVM instance = new SequenceFilePanelVM();
        public static SequenceFilePanelVM Instance { get { return instance; } }
        #endregion
    }
}
