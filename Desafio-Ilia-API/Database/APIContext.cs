using Desafio_Ilia_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Desafio_Ilia_API.Database
{
    public class APIContext : DbContext
    {
        private string DataSource = "(localdb)\\MSSQLLocalDB";
        private string DatabaseName = "APIDatabase";
        private string ConnectionString;

        public APIContext() => 
            ConnectionString = $"server=.;data source={DataSource};initial catalog={DatabaseName};" +
            "integrated security=True;MultipleActiveResultSets=True;" +
            "App=EntityFramework;TrustServerCertificate=true";

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(ConnectionString, x => x.EnableRetryOnFailure());
        }

        public DbSet<Alocacao> Alocacoes { get; set; }
        public DbSet<Registro> Registros { get; set; }
        public DbSet<Relatorio> Relatorios { get; set; }
    }
}
