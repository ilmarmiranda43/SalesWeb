using SystemSallesWeb.Data;
using SystemSallesWeb.Models;

namespace SystemSallesWeb.Services
{
    public class SellerService
    {
        private readonly SystemSallesWebContext _context;

        public SellerService(SystemSallesWebContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

    }
}
