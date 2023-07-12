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
    /// Interação lógica para CadastraCliente.xam
    /// </summary>
    public partial class CadastraCliente : UserControl
    {

        public CadastraCliente() => InitializeComponent();
        
        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string listaJogoVenda = listaJogos_RegistroVenda.Text;
            string nomeClienteVenda = nomeCliente_RegistroVenda.Text;
            string emailVenda = email_RegistroVendas.Text;
            int quantidadeVenda = int.Parse(qtd_RegistroVendas.Text);

            CadastraJogo cadastraJogo = new CadastraJogo();

            string erro = "";

            if (string.IsNullOrEmpty(nomeClienteVenda))
            {
                MessageBox.Show(erro, "Erro no nome" + "\n");
            }
            if (quantidadeVenda <= 0)
            {
                MessageBox.Show(erro, "Erro na quatidade" + "\n");
            }
           
          


            if (erro != "")
            {
                MessageBox.Show(erro, "Erro");
            }
            else
            {
                //Chamar metodo para cadastrar o jogo

                // "Salvar" os dados
                string mensagem ="Nome do Jogo : " + listaJogoVenda + "\n" + "Nome do Cliente: " + nomeClienteVenda + "\n" +
                    "Quantidade : " + quantidadeVenda + "\n" + "Valor Total : R$ " + quantidadeVenda  + "\n";
                    

                MessageBox.Show(mensagem, "Dados da Venda Cadastrados");
            }
        }
    }
}
