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

namespace imcApp_WPF.Formularios
{
    /// <summary>
    /// Lógica interna para windowCalculo.xaml
    /// </summary>
    public partial class windowCalculo : Window
    {
        public windowCalculo()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            var alturaUsuario = Convert.ToDouble(txtAltura.Text);
            var pesoUsuario = Convert.ToDouble(txtPeso.Text);
            double userResult = pesoUsuario / (alturaUsuario * alturaUsuario);

            txtResultado.Text = $"O seu IMC é {userResult.ToString()}";

            if(userResult < 18.5)
            {
                txtResultado2.Text = "Magreza";
            }
            else if (userResult >= 18.5 && userResult <= 24.9)
            {
                txtResultado2.Text = "Normal";

            }
            if (userResult >= 25 && userResult <= 29.9)
            {
                txtResultado2.Text = "Sobrepeso";

            }
            else if (userResult >= 30 && userResult <= 39.9)
            {
                txtResultado2.Text = "Obesidade";

            }
            if (userResult >= 40)
            {
                txtResultado2.Text = "Obesidade Grave";

            }

            txtAltura.Clear();
            txtPeso.Clear();
            txtIdade.Clear();
        }
    }
}
