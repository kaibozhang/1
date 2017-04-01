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
        #region ctor
        public TestModulePanelVM()
        {
            App.Messenger.Register<MethodInfoVM>(Messages.Method_SelectionChanged, OnMethodSelectionChanged);
            App.Messenger.Register<ClassInfoVM>(Messages.Class_SelectionChanged, OnClassSelectionChanged);
        }
        #endregion

        #region members
        ObservableCollection<TestModuleVM> testModuleVMs = new ObservableCollection<TestModuleVM>();
        static MethodInfoVM currentMethodInfoVM = null;
        #endregion

        #region props
        public ObservableCollection<TestModuleVM> TestModuleVMs
        {
            get { return testModuleVMs; }
        }
        #endregion

        #region callbacks
        void OnMethodSelectionChanged(MethodInfoVM miVM)
        {
            if (miVM.IsSelected == true)
            {
                currentMethodInfoVM = miVM;
                RaisePropertyChanged("AddStepCmd");
            }
        }
        void OnClassSelectionChanged(ClassInfoVM ciVM)
        {
            if (ciVM.IsSelected == true)
            {
                currentMethodInfoVM = null;
                RaisePropertyChanged("AddStepCmd");
            }
        }
        #endregion

        #region commands

        #region testModule section
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
            var openFileDialog = new Microsoft.Win32.OpenFileDialog();
            openFileDialog.Filter = "Dll Files (*.dll)|*.dll|Exe Files (*.exe)|*.exe";
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

        #region step operation
        RelayCommand addStep = null;
        public ICommand AddStepCmd
        {
            get
            {
                if (addStep == null)
                {
                    addStep = new RelayCommand(OnAddStep, CanAddStep);
                }
                return addStep;
            }
        }

        void OnAddStep()
        {
            if (currentMethodInfoVM == null)
            {
                return;
            }
            App.Messenger.NotifyColleagues(Messages.AddStepWithMethod, currentMethodInfoVM);
        }
        bool CanAddStep()
        {
            if (currentMethodInfoVM == null)
            {
                return false;
            }
            return true;
        }
        #endregion

        #endregion
    }
}
