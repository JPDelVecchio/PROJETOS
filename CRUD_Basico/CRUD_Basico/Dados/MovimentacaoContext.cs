using CRUD_basico.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Basico.Dados
{
    public class MovimentacaoContext : DbContext
    {
        public DbSet<ClienteFornecedor> ClientesFornecedores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-7TSFR77V;Initial Catalog=MOVIMENTACAO;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            //base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClienteFornecedor>()
                .ToTable("CLIFOR");

            modelBuilder.Entity<ClienteFornecedor>()
                .Property(a => a.Id)
                .HasColumnName("IDCLIFOR");

            modelBuilder.Entity<ClienteFornecedor>()
                .Property(a => a.Nome)
                .HasColumnType("Varchar(200)")
                .IsRequired();

            modelBuilder.Entity<ClienteFornecedor>()
                .Property(a => a.Cnpj)
                .HasColumnType("Varchar(30)")
                .IsRequired();
            modelBuilder.Entity<ClienteFornecedor>()
                .Property(a => a.Endereco)
                .HasColumnType("Varchar(200)")
                .IsRequired();
            modelBuilder.Entity<ClienteFornecedor>()
                .Property(a => a.Telefone)
                .HasColumnType("Varchar(15)");


            /* shadow properties */
            //modelBuilder.Entity<ClienteFornecedor>()
            //    .Property<DateTime>("DATAATUALIZACAO")
            //    .HasColumnType("DATETIME")
            //    .IsRequired();
            // inserir valor pela shadown -> na instancia declarar a seguinete --> Contexto.Entry("DATAATUALIZACAO").CurrentValue = DateTimw.Now;


            //base.OnModelCreating(modelBuilder);
        }
    }
}
