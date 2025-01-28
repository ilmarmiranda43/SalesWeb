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

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
