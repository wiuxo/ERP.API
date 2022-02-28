using System.Runtime;
using ERP.Core.Repositories;
using ERP.Entities.Models;

namespace ERP.DAL.Repositories;

public class ProductRepository : GenericRepository<Product, AppDbContext>, IProductRepository
{
    private readonly AppDbContext _context;

    public ProductRepository(AppDbContext context) : base(context)
    {
        _context = context;
    }
}