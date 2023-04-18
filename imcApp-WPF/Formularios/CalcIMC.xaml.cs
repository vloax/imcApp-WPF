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

namespace imcApp_WPF.Formularios
{
    /// <summary>
    /// Interação lógica para CalcIMC.xam
    /// </summary>
    public partial class CalcIMC : Page
    {
        List<Imc> imcList = new List<Imc>();

        public CalcIMC()
        {
            InitializeComponent();
        }
        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            var userSex = "Masculino";
            var alturaUsuario = Convert.ToDouble(txtAltura.Text);
            var pesoUsuario = Convert.ToDouble(txtPeso.Text);
            double userResult = pesoUsuario / (alturaUsuario * alturaUsuario);

            txtResultado.Text = $"O seu IMC é {userResult.ToString()}";

        }
    }
}
