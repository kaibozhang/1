using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TriCheer.Phoenix.SequenceFile
{
    public interface ITestItem
    {
        #region attributes
        string Name { get; set; }
        string Description { get; set; }
        TestItemTypes TestItemType { get; set; }
        List<ITestItem> Childs { get; set; }
        #endregion

        #region debug
        bool BreakPoint { get; set; }
        bool IsEnableLogging { get; set; }
        #endregion

        #region execution
        int TestTimeout { get; set; }
        RunModes RunMode { get; set; }
        TestItemGroup TestItemGroup { get; set; }
        #endregion
    }
}
