using MvvmFoundation.Wpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using TriCheer.Phoenix.ModuleAdaptor;

namespace Tricheer.Phoneix.SimpleSequenceEditor.VM
{
    class TestModulePanelVM : ObservableObject
    {
        #region members
        ObservableCollection<TestModuleVM> testModuleVMs = new ObservableCollection<TestModuleVM>();
        #endregion

        #region props
        public ObservableCollection<TestModuleVM> TestModuleVMs
        {
            get { return testModuleVMs; }
        }
        #endregion

        #region commands
        RelayCommand addTestModuleCmd = null;
        public ICommand AddTestModuleCmd
        {
            get
            {
                if (addTestModuleCmd == null)
                {
                    addTestModuleCmd = new RelayCommand(OnAddTestModule);
                }
                return addTestModuleCmd;
            }
        }
        void OnAddTestModule()
        {
            var openFileDialog = new Microsoft.Win32.OpenFileDialog()
            {
                Filter = "Dll Files (*.dll)|*.dll"
            };
            var result = openFileDialog.ShowDialog();
            string testModulePath = string.Empty;
            if (result == true)
            {
                testModulePath = openFileDialog.FileName;
            }
            else
            {
                return;
            }

            ITestModule testModule = TestModuleFactory.LoadTestModule(testModulePath);
            if (testModule == null)
            {
                return;
            }
            this.testModuleVMs.Add(new TestModuleVM(testModule));
            RaisePropertyChanged("TestModuleVMs");
        }
        #endregion
    }
}
