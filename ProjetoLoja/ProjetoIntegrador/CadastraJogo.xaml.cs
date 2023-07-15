using ProjetoIntegrador.Class;
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
    /// Interação lógica para CadastraJogo.xam
    /// </summary>
    public partial class CadastraJogo : UserControl
    {
        private LojaContexto contexto = new LojaContexto();

        public CadastraJogo()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string nomeJogo = nomeJogo_Textbox.Text;
            int codigoJogo = int.Parse(codigoJogo_TextBox.Text);
            string tipoJogo = TipoJogo_ComboBox.Text;
            int quantidade = int.Parse(quantidadeJogo_TextBox.Text);
            double valor = double.Parse(valorJogo_TextBox.Text);

            string erro = "";

            if (string.IsNullOrEmpty(nomeJogo))
            {
                erro = "Nome do Jogo Inválido \n";
            }
            if (codigoJogo <= 0)
            {
                erro += "Codigo do Jogo inválido \n";
            }
            if (string.IsNullOrEmpty(tipoJogo))
            {
                erro = "Tipoe do Jogo Inválido \n";
            }
            if (quantidade <= 0)
            {
                erro += "Informar a quantidade \n";
            }
            if(valor <= 0)
            {
                erro += "Informar Valor \n";
            }


            if (erro != "")
            {
                MessageBox.Show(erro, "Erro");
            }
            else
            {
                Jogo jogo = new Jogo();
                jogo.NomeJogo = nomeJogo;
                jogo.Descricao = tipoJogo;
                jogo.Codigo = codigoJogo;
                jogo.Preco = valor;
                jogo.Quantidade = quantidade;
                contexto.Jogo.Add(jogo);
                contexto.SaveChanges();

                // "Salvar" os dados
                string mensagem = "Nome do jogo: " + nomeJogo + "\n" +
                    "Código do jogo: "   + codigoJogo + "\n" + "Tipo do jogo" + tipoJogo + "\n" +
                    "Quantidade : " + quantidade + "\n" + "Valor Uni: " + valor ;

                MessageBox.Show(mensagem, "Dados do Jogo Cadastrados");
            }

        }

       



    }
}
