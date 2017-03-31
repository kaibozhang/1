using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TriCheer.Phoenix.ModuleAdaptor
{
    public class TestModuleFactory
    {
        public static ITestModule LoadTestModule(string filePath)
        {
            if (!File.Exists(filePath))
            {
                return null;
            }
            ITestModule testModule = null;
            try
            {
                testModule = DotNetTestModule.LoadTestModule(filePath);
                return testModule;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
