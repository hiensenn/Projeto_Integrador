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

namespace ProjetoIntegrador
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

       

        private void CadastrarCliente(object sender, RoutedEventArgs e)
        {
            MostrarJanela<CadastraCliente>();
        }

        private void CadastrarJogo(object sender, RoutedEventArgs e)
        {
            MostrarJanela<CadastraJogo>();
        }

        private void Estoque(object sender, RoutedEventArgs e)
        {
            MostrarJanela<Estoque>();
        }

        private void EditarCliente(object sender, RoutedEventArgs e)
        {
            MostrarJanela<EditarCliente>();
        }

        private void EditarJogo(object sender, RoutedEventArgs e)
        {
            MostrarJanela<EditarJogo>();
        }



        private void MostrarJanela<T>() where T : UserControl, new()
        {
            var filhos = PainelForms.Children.OfType<T>();
            // "filhos" é uma coleção de janelas do tipo CadastrarJogador já inseridas
            // no painel

            T janela;
            if (filhos.Count() == 0)
            {
                //Não existe controle do tipo CadastrarJogador
                janela = new T(); //UserControl criado
                PainelForms.Children.Add(janela);
            }
            else
            {
                // Trazer a janela para frente
                janela = filhos.First();
            }

            foreach (var filho in PainelForms.Children)
            {
                var filhoControle = (UserControl)filho;
                if (filhoControle == janela)
                    filhoControle.Visibility = Visibility.Visible;
                else
                    filhoControle.Visibility = Visibility.Hidden;
            }
        }
    }
}
