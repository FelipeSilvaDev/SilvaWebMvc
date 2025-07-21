using SilvaWebMvc.Models;
using System.Collections.Generic;
using System.Linq;

namespace SilvaWebMvc.Services
{
    public class DepartmentService
    {
        private readonly SilvaWebMvcContext _context;

        public DepartmentService(SilvaWebMvcContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
