using SilvaWebMvc.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SilvaWebMvc.Services
{
    public class DepartmentService
    {
        private readonly SilvaWebMvcContext _context;

        public DepartmentService(SilvaWebMvcContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
