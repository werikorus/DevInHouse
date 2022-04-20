using Microsoft.EntityFrameworkCore;
using api_codefirst.Models;

namespace api_codefirst.Context
{
    public class Sqlcontext : DbContext 
    {
        public Sqlcontext(DbContextOptions<Sqlcontext> options) : base(options) { }

        public DbSet<Imovel> Imoveis { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Endereco>()
                .ToTable("enderecos_sistema")
                .Property(x => x.Complemento)
                .HasColumnName("complemento")
                .HasMaxLength(20);

            modelBuilder.Entity<Endereco>()
                .Property(x => x.Bairro)
                .HasColumnName("bairro")
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<Endereco>()
                .Property(x => x.Cidade)
                .HasColumnName("cidade")
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<Endereco>()
                .Property(x => x.Numero)
                .HasColumnName("numero")
                .IsRequired()
                .HasMaxLength(10);


            modelBuilder.Entity<Endereco>()
                .Property(x => x.Referencia)
                .HasColumnName("referencia")
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<Endereco>()
                .Property(x => x.Rua)
                .HasColumnName("rua")
                .IsRequired()
                .HasMaxLength(200);

            modelBuilder.Entity<Endereco>()
                .Property(x => x.Uf)
                .HasColumnName("uf")
                .IsRequired()
                .HasMaxLength(2);

            modelBuilder.Entity<Endereco>()
                .Property(x => x.Cep)
                .HasColumnName("cep")
                .IsRequired()
                .HasMaxLength(10);

            modelBuilder.Entity<Imovel>()
                .HasMany(x => x.Proprietarios)
                .WithMany(x => x.Imoveis);

            modelBuilder.Entity<Imovel>()
                .HasOne(x => x.Endereco)
                .WithMany(x => x.Imoveis);
        }
    }
}
