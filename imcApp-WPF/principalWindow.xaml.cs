using imcApp_WPF.Formularios;
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
using System.Windows.Shapes;

namespace imcApp_WPF
{
    /// <summary>
    /// Lógica interna para principalWindow.xaml
    /// </summary>
    public partial class principalWindow : Window
    {
        public principalWindow()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, RoutedEventArgs e)
        {
            var newWindow = new windowCalculo();
            newWindow.Show();
            Close();
        }
    }
}
