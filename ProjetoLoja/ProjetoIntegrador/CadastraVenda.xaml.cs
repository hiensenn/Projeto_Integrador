using Google.Protobuf.WellKnownTypes;
using ProjetoIntegrador.Class;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
		private LojaContexto contexto = new LojaContexto();
		public CadastraCliente() => InitializeComponent();
        
        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string listaJogoVenda = listaJogos_RegistroVenda.Text;
            string nomeClienteVenda = nomeCliente_RegistroVenda.Text;
            string emailVenda = email_RegistroVendas.Text;
            string cpf = cpf_RegistroVendas.Text;

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
				using (LojaContexto contextLoja = new LojaContexto())
				{
					Vendas venda = new Vendas();
					venda.Nome = nomeClienteVenda;
					venda.email = emailVenda;
					venda.Data = DateTime.Now;
					venda.cpf = cpf;
					venda.quantidade = quantidadeVenda;
                    var context = contextLoja.Jogo.FirstOrDefault(x => x.NomeJogo == listaJogoVenda);
					venda.Valor = context.Preco * quantidadeVenda;
					venda.Id_Jogo = context.Id_Jogo;
			
					contexto.Venda.Add(venda);
					contexto.SaveChanges();
				}
				
				// "Salvar" os dados
				string mensagem ="Nome do Jogo : " + listaJogoVenda + "\n" + "Nome do Cliente: " + nomeClienteVenda + "\n" +
                    "Quantidade : " + quantidadeVenda + "\n" + "Valor Total : R$ " + quantidadeVenda  + "\n";
                    

                MessageBox.Show(mensagem, "Dados da Venda Cadastrados");
            }
        }

		private void listaJogos_RegistroVenda_Loaded(object sender, RoutedEventArgs e)
		{
			using (var dbContext = new LojaContexto())
			{
				var jogos = dbContext.Jogo.Select(j => j.NomeJogo).ToList();

				listaJogos_RegistroVenda.ItemsSource = jogos;
			}
		}

	}
}
