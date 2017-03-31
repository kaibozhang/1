using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace TriCheer.Phoenix.ModuleAdaptor
{
    class DotNetTestModule : ITestModule
    {
        #region ctor
        private DotNetTestModule()
        {
        }
        #endregion

        #region members
        string fullPath;
        List<IClassInfo> classInfos = new List<IClassInfo>();
        #endregion

        #region props
        public string Name
        {
            get
            {
                return Path.GetFileNameWithoutExtension(fullPath);
            }
        }
        public List<IClassInfo> ClassInfos
        {
            get
            {
                return classInfos;
            }
        }
        #endregion

        #region methods
        public static DotNetTestModule LoadTestModule(string filePath)
        {
            DotNetTestModule testModule = new DotNetTestModule();
            Assembly assembly = Assembly.LoadFile(filePath);
            Type[] types = assembly.GetTypes();
            foreach (Type t in types)
            {
                DotNetClassInfo dci = new DotNetClassInfo(t);
                testModule.classInfos.Add(dci);
            }
            testModule.fullPath = filePath;
            return testModule;
        }
        #endregion

    }
}
