using System;
using System.Collections.Generic;
using System.Linq;
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
using WPFandADO.ADO;
using WPFandADO.WPF;

namespace WPFandADO
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

        private void Containers_Click(object sender, RoutedEventArgs e)
        {
            new Containers().ShowDialog();
        }

        private void ContainersHome_Click(object sender, RoutedEventArgs e)
        {
            new ContainersHome().ShowDialog();
        }

        private void Mine_Click(object sender, RoutedEventArgs e)
        {
            new Mine().ShowDialog();
        }

        private void Canvas_Click(object sender, RoutedEventArgs e)
        {
            new Canvasmy().ShowDialog();
        }

        private void Styles_Click(object sender, RoutedEventArgs e)
        {
            new Styles().ShowDialog();
        }

        private void Triggers_Click(object sender, RoutedEventArgs e)
        {
            new Triggers().ShowDialog();
        }

        private void TriStyHome_Click(object sender, RoutedEventArgs e)
        {
            new StylesTriggersHome().ShowDialog();
        }

        private void DnD_Click(object sender, RoutedEventArgs e)
        {
            new DnD().ShowDialog();
        }

        private void ADObasic_Click(object sender, RoutedEventArgs e)
        {
            new ADObasic().ShowDialog();    
        }
    }
}
