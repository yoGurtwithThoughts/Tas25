using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Xceed.Wpf.Toolkit;
using Xceed.Wpf.AvalonDock;
using System.Xml.Linq;

using Xceed.Wpf.AvalonDock.Layout;

namespace Tas25
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BTLoadDoc_Click(object sender, RoutedEventArgs e, object documentPanel)
        {
           var document = new LayoutDocument();

            
            documentPanel.Items.Add(document);

            
            documentPanel.SelectedItem = document;
        }

        private void BTCancelDoc_Click(object sender, RoutedEventArgs e, object documentPanel)
        {
            documentPanel.Items.Remove(documentPanel.SelectedItem);

        }
    }
}
