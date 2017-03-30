using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows;
using AvalonDock.Layout;

namespace TriCheer.Phoenix.SeqEditor
{
    public class PanesTemplateSelector : DataTemplateSelector
    {
        public PanesTemplateSelector()
        {
        
        }


        public DataTemplate SequenceFileViewTemplate
        {
            get;
            set;
        }

        public DataTemplate StepSettingsTemplate
        {
            get;
            set;
        }

        public DataTemplate TestModuleMgrTemplate
        {
            get;
            set;
        }

        public override System.Windows.DataTemplate SelectTemplate(object item, System.Windows.DependencyObject container)
        {
            var itemAsLayoutContent = item as LayoutContent;

            if (item is SequenceFileVM)
                return SequenceFileViewTemplate;

            if (item is StepSettingsVM)
                return StepSettingsTemplate;

            return base.SelectTemplate(item, container);
        }
    }
}
