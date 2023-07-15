using ProjetoIntegrador.Class;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
    /// Interação lógica para EditarCliente.xam
    /// </summary>
    public partial class EditarCliente : UserControl
    {
        public EditarCliente()
        {
            InitializeComponent();
        }

        private void OkClick(object sender, RoutedEventArgs e)
        {
        }

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			LojaContexto lojaContexto = new LojaContexto();
			var context = lojaContexto.Venda.FirstOrDefault(x => x.cpf == CPF.Text);
			lojaContexto.Venda.Remove(context);
			lojaContexto.SaveChanges();
		}

		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			LojaContexto lojaContexto = new LojaContexto();
			var context = lojaContexto.Venda.FirstOrDefault(x => x.cpf == CPF.Text);
			
			context.Nome = NomeTextBox.Text;
			context.cpf= CPF.Text;
			context.Valor = double.Parse(ValorTextBox.Text);
			context.email = EmailTextBox.Text;
			context.quantidade = int.Parse(QuantidadeTextBox.Text);
			lojaContexto.SaveChangesAsync();
		}
    }
}
