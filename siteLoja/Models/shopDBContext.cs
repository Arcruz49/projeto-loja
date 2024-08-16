using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace siteLoja.Models
{
    public partial class shopDBContext : DbContext
    {
        public shopDBContext()
        {
        }

        public shopDBContext(DbContextOptions<shopDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CadCategoria> CadCategoria { get; set; } = null!;
        public virtual DbSet<CadProduto> CadProdutos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=shopDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CadCategoria>(entity =>
            {
                entity.HasKey(e => e.CdCategoria)
                    .HasName("PK__cadCateg__FC27A93F5CA7427B");

                entity.ToTable("cadCategoria");

                entity.Property(e => e.CdCategoria).HasColumnName("cdCategoria");

                entity.Property(e => e.DescCategoria)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("descCategoria");

                entity.Property(e => e.DtAlteracao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtAlteracao");

                entity.Property(e => e.DtCriacao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtCriacao");

                entity.Property(e => e.Inativo).HasColumnName("inativo");

                entity.Property(e => e.NmCategoria)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("nmCategoria");
            });

            modelBuilder.Entity<CadProduto>(entity =>
            {
                entity.HasKey(e => e.CdProduto)
                    .HasName("PK__cadProdu__8897B773DEB979FD");

                entity.ToTable("cadProduto");

                entity.Property(e => e.CdProduto).HasColumnName("cdProduto");

                entity.Property(e => e.CdCategoria).HasColumnName("cdCategoria");

                entity.Property(e => e.DtAlteracao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtAlteracao");

                entity.Property(e => e.DtCriacao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtCriacao");

                entity.Property(e => e.EmEstoque).HasColumnName("emEstoque");

                entity.Property(e => e.ImagemUrl)
                    .IsUnicode(false)
                    .HasColumnName("imagemUrl");

                entity.Property(e => e.ImagemUrlThumb)
                    .IsUnicode(false)
                    .HasColumnName("imagemUrlThumb");

                entity.Property(e => e.Inativo).HasColumnName("inativo");

                entity.Property(e => e.NmProduto)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("nmProduto");

                entity.Property(e => e.Preco).HasColumnName("preco");

                entity.HasOne(d => d.CdCategoriaNavigation)
                    .WithMany(p => p.CadProdutos)
                    .HasForeignKey(d => d.CdCategoria)
                    .HasConstraintName("FK_cdCategoria");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
