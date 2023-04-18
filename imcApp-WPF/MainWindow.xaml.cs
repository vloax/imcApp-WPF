using System;
using System.Collections.Generic;
using System.Drawing;
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
using imcApp_WPF.RegrasDeNegocio;

namespace imcApp_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Imc> imcList = new List<Imc>();

        public MainWindow()
        {
            InitializeComponent();

        }

        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            var userSex = "Masculino";
            var alturaUsuario = Convert.ToDouble(txtAltura.Text);
            var pesoUsuario = Convert.ToDouble(txtPeso.Text);
            double userResult = pesoUsuario / (alturaUsuario *  alturaUsuario);

            txtResultado.Text = $"O seu IMC é {userResult.ToString()}";

        }

    }

}