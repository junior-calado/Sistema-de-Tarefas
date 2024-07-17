using Microsoft.EntityFrameworkCore;
using SistemasDeTarefas.Data.Map;
using SistemasDeTarefas.Models;

namespace SistemasDeTarefas.Data
{
    public class SistemaTarefasDBContext : DbContext
    {
        //configurando as tabelas e config gerais
        public SistemaTarefasDBContext(DbContextOptions<SistemaTarefasDBContext> options) : base(options) 
        { 
        }


        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<TarefaModel> Tarefas { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new TarefaMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
