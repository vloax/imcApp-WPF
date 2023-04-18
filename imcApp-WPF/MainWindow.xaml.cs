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
            var userHeight = Convert.ToInt32(txtAltura.Text);
            var userWeight = Convert.ToInt32(txtPeso.Text);


            if (userHeight > 240)
            {
                MessageBox.Show("Altura maior do que a aceitada, digite novamente", "Erro - ALTURA!");
                txtPeso.Focus();
                txtPeso.Clear();
                txtIdade.Clear();
                txtAltura.Clear();
            }

            if (btnFeminino.IsPressed)
            {
                userSex = "Feminino";
            }
            
            Imc imc = new Imc();

            imc.Altura = userHeight;
            imc.Sexo = userSex;
            imc.Peso = userWeight;
            imc.ResultadoFinal = userWeight / (userHeight * userHeight);

            imcList.Add(imc);
 
        }
    }
}
