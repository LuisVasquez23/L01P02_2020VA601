using L01P02_2020VA601.Models;
using Microsoft.EntityFrameworkCore;

namespace L01P02_2020VA601.Data
{
    public class restauranteContext : DbContext
    {

        public restauranteContext(DbContextOptions<restauranteContext> options) : base(options)
        {

        }

        public DbSet<pedidos> Pedidos { get; set; } 
        public DbSet<platos> Platos { get; set; }
        public DbSet<motoristas> Motoristas { get; set; }
        public DbSet<clientes> Clientes { get; set;}

    }
}
