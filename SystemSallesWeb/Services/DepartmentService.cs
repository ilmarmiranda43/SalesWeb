using Microsoft.EntityFrameworkCore;
using SystemSallesWeb.Data;
using SystemSallesWeb.Models;


namespace SystemSallesWeb.Services
{
    public class DepartmentService
    {
        private readonly SystemSallesWebContext _context;

        public DepartmentService(SystemSallesWebContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
