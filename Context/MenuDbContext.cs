using GraphQLExemplo.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQLExemplo.Context
{
    public class MenuDbContext : DbContext
    {
        public MenuDbContext(DbContextOptions<MenuDbContext>options): base(options)
        {
        }

        public DbSet<Menu> Menus { get; set; }
    }
}
