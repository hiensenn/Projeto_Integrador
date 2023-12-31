﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoIntegrador.Class
{
    [Table("Vendas")]

		public class Vendas
		{
			[Key]
			[Column("Id_Venda")]
			public int Id_Venda { get; set; }

			[Column("Id_Jogo")]
			public int Id_Jogo { get; set; }
			[ForeignKey("Id_Jogo")]
			public Jogo Jogo { get; set; }
			public string Nome { get; set; }
			public string email { get; set; }
			public string cpf { get; set; }
			public int quantidade { get; set; }
			public DateTime Data { get; set; }
			public double Valor { get; set; }
			
	}
}
