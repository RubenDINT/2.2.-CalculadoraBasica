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

namespace CalculadoraBasica
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click_Calcular(object sender, RoutedEventArgs e)
        {
            try 
            {
                switch (operadorTextBlock.Text)
                {
                    case "+":
                        resultadoTextBlock.Text = (int.Parse(operando1TextBlock.Text) + int.Parse(operando2TextBlock.Text)).ToString();
                        break;
                    case "-":
                        resultadoTextBlock.Text = (int.Parse(operando1TextBlock.Text) - int.Parse(operando2TextBlock.Text)).ToString();
                        break;
                    case "*":
                        resultadoTextBlock.Text = (int.Parse(operando1TextBlock.Text) * int.Parse(operando2TextBlock.Text)).ToString();
                        break;
                    case "/":
                        resultadoTextBlock.Text = (float.Parse(operando1TextBlock.Text) / float.Parse(operando2TextBlock.Text)).ToString();
                        break;
                    case "":
                        break;
                    default:
                        break;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Formato erróneo");
            }
            catch(Exception)
            {
                MessageBox.Show("Algo ha salido mal");
            }
        }
        private void operadorTextBlock_TextChanged(object sender, TextChangedEventArgs e)
        {
            switch (operadorTextBlock.Text)
            {
                case "+":
                    calcularButton.IsEnabled = true;
                    break;
                case "-":
                    calcularButton.IsEnabled = true;
                    break;
                case "*":
                    calcularButton.IsEnabled = true;
                    break;
                case "/":
                    calcularButton.IsEnabled = true;
                    break;
                default:
                    calcularButton.IsEnabled = false;
                    break;
            }
        }

        private void limpiarButton_Click(object sender, RoutedEventArgs e)
        {
            operando1TextBlock.Text = String.Empty;
            operando2TextBlock.Text = String.Empty;
            operadorTextBlock.Text = String.Empty;
            resultadoTextBlock.Text = String.Empty;
        }
    }
}
