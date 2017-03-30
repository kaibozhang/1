using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TriCheer.Phoenix.SeqEditor
{
    /// <summary>
    /// Interaction logic for SequenceEditor.xaml
    /// </summary>
    public partial class SequenceEditor : Window
    {
        public SequenceEditor()
        {
            InitializeComponent();
            this.DataContext = SequenceEditorVM.Instance;
        }
    }
}
