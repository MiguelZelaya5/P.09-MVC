using Microsoft.EntityFrameworkCore;
using P._09_MVC.Models;
namespace P._09_MVC.Models
{
    public class equiposDbContext :DbContext
    {
        public equiposDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<marcas>? marcas { get; set; }
    }
}
