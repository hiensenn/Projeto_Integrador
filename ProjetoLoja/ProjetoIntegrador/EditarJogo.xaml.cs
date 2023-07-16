using Google.Protobuf.WellKnownTypes;
using ProjetoIntegrador.Class;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
	/// Interação lógica para EditarJogo.xam
	/// </summary>
	public partial class EditarJogo : UserControl
	{
		public EditarJogo()
		{
			InitializeComponent();
		}

		private void OkClick(object sender, RoutedEventArgs e)
		{

		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			LojaContexto lojaContexto = new LojaContexto();

			int codigo = int.Parse((codigoTxt.Text));

			var context = lojaContexto.Jogo.FirstOrDefault(x => x.Codigo == codigo);
			lojaContexto.Jogo.Remove(context);
			lojaContexto.SaveChanges();

		}

		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			LojaContexto lojaContexto = new LojaContexto();
			var context = lojaContexto.Jogo.FirstOrDefault(x => x.NomeJogo == NomeTextBox.Text);

			if (context != null)
			{
				context.NomeJogo = NomeTextBox.Text;
				context.Descricao = Descricao.Text;
				context.Codigo = int.Parse(codigoTxt.Text);
				context.Preco = double.Parse(ValorTextBox.Text);
				context.Quantidade = int.Parse(QuantidadeTextBox.Text);
				lojaContexto.SaveChangesAsync();

			}



		}
	}

}