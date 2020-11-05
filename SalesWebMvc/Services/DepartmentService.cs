using SalesWebMvc.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMvc.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvcContext _context;

        public DepartmentService(SalesWebMvcContext context)
        {
            _context = context;
        }

        //Operacao sera assincrona
        public async Task<List<Department>> FindAllAsync()
        {
            //_context.Department.ToList();
            return await _context.Department
                        .OrderBy(x => x.Name)
                        .ToListAsync();
        }
    }
}
