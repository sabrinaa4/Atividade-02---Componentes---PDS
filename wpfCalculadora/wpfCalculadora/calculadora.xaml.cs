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

namespace wpfCalculadora
{
    /// <summary>
    /// Lógica interna para calculadora.xaml
    /// </summary>
    public partial class calculadora : Window
    {
        int numero1;
        int numero2;
        int total;

        public calculadora()
        {
            InitializeComponent();
        }

        private void soma(object sender, RoutedEventArgs e)
        {
            numero1 = Convert.ToInt32(valor1.Text);
            numero2 = Convert.ToInt32(valor2.Text);

            total = numero1 + numero2;

            resultado.Content = total.ToString();
        }

        private void subtracao(object sender, RoutedEventArgs e)
        {
            numero1 = Convert.ToInt32(valor1.Text);
            numero2 = Convert.ToInt32(valor2.Text);

            total = numero1 - numero2;

            resultado.Content = total.ToString();
        }

        private void multiplicacao(object sender, RoutedEventArgs e)
        {
            numero1 = Convert.ToInt32(valor1.Text);
            numero2 = Convert.ToInt32(valor2.Text);

            total = numero1 * numero2;

            resultado.Content = total.ToString();
        }

        private void divisao(object sender, RoutedEventArgs e)
        {
            numero1 = Convert.ToInt32(valor1.Text);
            numero2 = Convert.ToInt32(valor2.Text);

            double total = (double)numero1 / numero2;

            resultado.Content = total.ToString();
        }
    }
}
