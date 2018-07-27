namespace ProjetoHotelVS.DAL
{
    using ProjetoHotelVS.Models;
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ReservasModel1 : DbContext
    {
        public ReservasModel1()
            : base("name=ReservasModel1")
        {

        }

        public virtual DbSet<bairro> bairros { get; set; }
        public virtual DbSet<cidade> cidades { get; set; }
        public virtual DbSet<Hotel> Hotels { get; set; }
        public virtual DbSet<logradouro> logradouros { get; set; }
        public virtual DbSet<Quarto> Quartos { get; set; }
        public virtual DbSet<Reserva> Reservas { get; set; }
        public virtual DbSet<Turista> Turistas { get; set; }
        public virtual DbSet<uf> ufs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<bairro>()
                .Property(e => e.desc_bairro)
                .IsUnicode(false);

            modelBuilder.Entity<bairro>()
                .HasMany(e => e.logradouros)
                .WithRequired(e => e.bairro)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cidade>()
                .Property(e => e.desc_cidade)
                .IsUnicode(false);

            modelBuilder.Entity<cidade>()
                .Property(e => e.flg_estado)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cidade>()
                .HasMany(e => e.bairros)
                .WithRequired(e => e.cidade)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Hotel>()
                .Property(e => e.Cep)
                .HasPrecision(8, 0);

            modelBuilder.Entity<Hotel>()
                .Property(e => e.Cidade)
                .IsUnicode(false);

            modelBuilder.Entity<Hotel>()
                .Property(e => e.Uf)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Hotel>()
                .Property(e => e.Ddd)
                .HasPrecision(2, 0);

            modelBuilder.Entity<Hotel>()
                .Property(e => e.Telefone)
                .HasPrecision(9, 0);

            modelBuilder.Entity<Hotel>()
                .HasMany(e => e.Quartos)
                .WithRequired(e => e.Hotel)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<logradouro>()
                .Property(e => e.desc_logradouro)
                .IsUnicode(false);

            modelBuilder.Entity<logradouro>()
                .Property(e => e.desc_tipo)
                .IsUnicode(false);

            modelBuilder.Entity<Quarto>()
                .HasMany(e => e.Reservas)
                .WithRequired(e => e.Quarto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Turista>()
                .Property(e => e.Cpf)
                .HasPrecision(9, 0);

            modelBuilder.Entity<Turista>()
                .HasMany(e => e.Reservas)
                .WithRequired(e => e.Turista)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<uf>()
                .Property(e => e.uf_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<uf>()
                .Property(e => e.desc_uf)
                .IsUnicode(false);

            modelBuilder.Entity<uf>()
                .HasMany(e => e.cidades)
                .WithRequired(e => e.uf)
                .HasForeignKey(e => e.flg_estado)
                .WillCascadeOnDelete(false);
        }
    }
}