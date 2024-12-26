using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExemploCurso.Domain.Entidades;
using ExemploCurso.Domain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;

namespace ExemploCurso.Repository.Contexto
{
    public class ExemploCursoContext : DbContext, IUnitOfWork
    {

        public ExemploCursoContext(DbContextOptions<ExemploCursoContext> options) : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            ChangeTracker.AutoDetectChangesEnabled = false;
        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<ItemPedido> ItemsPedido { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }



        public async Task<bool> Commit()
        {
            return await this.SaveChangesAsync() > 0;
        }
    }
}
