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

namespace imcApp_WPF
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

        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            var userAge = Convert.ToInt16(txtIdade.Text);
            var userHeight = Convert.ToInt32(txtAltura.Text);
            var userWeight = Convert.ToInt32(txtPeso.Text);

            var imcCalc = userWeight / (userHeight * userWeight);
        
             
        }
    }
}
