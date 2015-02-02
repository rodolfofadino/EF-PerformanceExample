using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Cadastro
    {
        public int Id { get; set; }
        public string EmailPrincipal { get; set; }
        public string NomeCompleto { get; set; }
        public DateTime? DataNascimento { get; set; }
    }

    public class CadastroContext : DbContext
    {
        public DbSet<Cadastro> Cadastros { get; set; }
        public CadastroContext()
            : base("Cadastro")
        {
            Database.SetInitializer<CadastroContext>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CadastroConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
    public class CadastroConfiguration : EntityTypeConfiguration<Cadastro>
    {
        public CadastroConfiguration()
        {
            ToTable(tableName: "CadastroExemplo", schemaName: "dbo");
            Property(x => x.NomeCompleto).HasColumnName("Nome");
            Property(x => x.EmailPrincipal).HasColumnName("Email").HasColumnType("varchar");
        }
    }
}
