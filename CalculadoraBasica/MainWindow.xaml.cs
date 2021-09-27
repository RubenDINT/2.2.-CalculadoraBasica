using System;
using System.Windows;
using System.Windows.Controls;

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
            catch (Exception)
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
