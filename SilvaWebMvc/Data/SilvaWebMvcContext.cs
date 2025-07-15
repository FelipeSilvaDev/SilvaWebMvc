using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace SilvaWebMvc.Models
{
    public class SilvaWebMvcContext : DbContext
    {
        public SilvaWebMvcContext(DbContextOptions<SilvaWebMvcContext> options)
            : base(options)
        {
        }
        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecords { get; set; }
        

    }
}
