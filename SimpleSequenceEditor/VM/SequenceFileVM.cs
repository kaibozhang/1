using MvvmFoundation.Wpf;
using System;
using System.Collections.Generic;
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
        }
        #endregion

        #region members
        ISequenceFile seqFile;
        #endregion

        #region props
        public string Name
        {
            get { return seqFile.Name; }
        }
        #endregion
    }
}
