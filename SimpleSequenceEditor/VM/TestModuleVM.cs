using MvvmFoundation.Wpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using TriCheer.Phoenix.ModuleAdaptor;

namespace Tricheer.Phoneix.SimpleSequenceEditor.VM
{
    class TestModuleVM : TreeViewItemViewModel
    {
        #region ctor
        public TestModuleVM(ITestModule testModule) : base(null, true)
        {
            this.testModule = testModule;
        }
        #endregion

        #region members
        ITestModule testModule;
        ObservableCollection<ClassInfoVM> classInfoVMs = new ObservableCollection<ClassInfoVM>();
        #endregion

        #region props
        public string Name { get { return testModule.Name; } }
        public ObservableCollection<ClassInfoVM> ClassInfoVMs { get { return classInfoVMs; } }
        #endregion

        #region methods
        protected override void LoadChildren()
        {
            if (testModule == null)
            {
                return;
            }

            foreach (IClassInfo ci in testModule.ClassInfos)
            {
                //classInfoVMs.Add(new ClassInfoVM(ci, this));
                base.Children.Add(new ClassInfoVM(ci, this));
            }
            //RaisePropertyChanged("ClassInfoVMs");
        }
        #endregion
    }
}
