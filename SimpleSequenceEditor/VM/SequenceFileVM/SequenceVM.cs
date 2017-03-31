using MvvmFoundation.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TriCheer.Phoenix.SeqManager.SeqFile;

namespace Tricheer.Phoneix.SimpleSequenceEditor.VM
{
    class SequenceVM : BaseTestItemVM
    {
        #region ctor
        public SequenceVM(ISequence seq) : base(null, true)
        {
            this.seq = seq;
        }
        #endregion

        #region members
        ISequence seq;
        #endregion

        #region props
        public string Name
        {
            get { return seq.Name; }
            set { seq.Name = value; RaisePropertyChanged("Name"); }
        }

        public override bool IsSelected
        {
            get
            {
                return base.IsSelected;
            }

            set
            {
                base.IsSelected = value;
                App.Messenger.NotifyColleagues(Messages.Sequence_SelectionChanged, this);
            }
        }
        #endregion

        #region methods
        protected override void LoadChildren()
        {
            if (seq == null)
            {
                return;
            }

            foreach (ITestItem item in seq.Children)
            {
                TestItemVM tivm = new TestItemVM(item, this);
                tivm.IsExpanded = true;
                base.Children.Add(tivm);
            }
        }
        #endregion
    }
}
