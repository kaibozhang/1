﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TriCheer.Phoenix.SeqManager.SeqFile
{
    public interface ITestItem
    {
        #region attributes
        string Name { get; set; }
        string Description { get; set; }
        TestItemTypes TestItemType { get; }
        TestItemGroups TestItemGroup { get; set; }
        List<ITestItem> Childs { get; set; }
        List<Variable> Variables { get; set; }
        #endregion

        #region debug
        bool BreakPoint { get; set; }
        bool EnableLogging { get; set; }
        #endregion

        #region execution
        int TestTimeout { get; set; }
        RunModes RunMode { get; set; }
        ILoopSettings LoopSettings { get; set; }
        #endregion
    }
}
