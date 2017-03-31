using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MvvmFoundation.Wpf;
using TriCheer.Phoenix.SeqManager.SeqFile;

namespace Tricheer.Phoneix.SimpleSequenceEditor.VM
{
    class StepSettingsVM : ObservableObject
    {
        #region ctor
        public StepSettingsVM(IStep step)
        {
            this.step = step;
        }
        #endregion

        #region members
        IStep step;
        #endregion
    }
}
