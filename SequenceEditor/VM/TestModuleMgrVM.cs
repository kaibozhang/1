using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MVVM.VMBase;

namespace TriCheer.Phoenix.SeqEditor
{
    public class TestModuleMgrVM : ViewModelBase
    {
        #region ctor for singleton
        static TestModuleMgrVM instance;
        private TestModuleMgrVM()
        {

        }

        public static TestModuleMgrVM Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TestModuleMgrVM();
                }
                return instance;
            }
        }
        #endregion
    }
}
