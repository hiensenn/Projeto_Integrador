using MySql.Data.EntityFramework;
using ProjetoIntegrador.Class;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntegrador
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class LojaContexto : DbContext
    {
        public LojaContexto() :
            base("server=localhost;database=loja;user=root;password=root")
        { }

        public DbSet<Vendas> Venda { get; set; }
        public DbSet<Jogo> Jogo { get; set; }

    }
}
