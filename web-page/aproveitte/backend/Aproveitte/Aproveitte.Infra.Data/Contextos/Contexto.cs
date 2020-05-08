using Aproveitte.Dominio.Entidades;
using Aproveitte.Infra.Data.Mapeamentos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;

namespace Aproveitte.Infra.Data.Contextos
{
    public class Contexto : DbContext
    {
        public DbSet<Receita> Receitas { get; set; }
        public DbSet<Ingrediente> Ingredientes { get; set; }
        public DbSet<Unidade> Unidades { get; set; }

        public IDbContextTransaction Transaction { get; private set; }

        public Contexto(DbContextOptions<Contexto> options)
            : base(options)
        {
            if (Database.GetPendingMigrations().Count() > 0)
                Database.Migrate();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }

        public IDbContextTransaction InitTransacao()
        {
            if (Transaction == null) Transaction = this.Database.BeginTransaction();
            return Transaction;
        }


        private void RollBack()
        {
            if (Transaction != null)
            {
                Transaction.Rollback();
            }
        }

        private void Salvar()
        {
            try
            {
                ChangeTracker.DetectChanges();
                SaveChanges();
            }
            catch (Exception ex)
            {
                RollBack();
                throw new Exception(ex.Message);
            }
        }

        private void Commit()
        {
            if (Transaction != null)
            {
                Transaction.Commit();
                Transaction.Dispose();
                Transaction = null;
            }
        }

        public void SendChanges()
        {
            Salvar();
            Commit();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Receita>(new ReceitaMap().Configure);
            modelBuilder.Entity<Ingrediente>(new IngredienteMap().Configure);
            modelBuilder.Entity<Unidade>(new UnidadeMap().Configure);

        }
    }

}

