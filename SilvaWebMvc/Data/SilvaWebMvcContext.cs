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
        public DbSet<SilvaWebMvc.Models.Department> Department { get; set; }

    }
}
