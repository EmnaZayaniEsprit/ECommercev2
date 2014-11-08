using ECmmerce.Data.Infrasctructure;

using ECmmerce.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECmmerce.Data.Infrastructure
{
    public class ProductRepository : RepositoryBase <product> ,IProductRepository
    {
                public ProductRepository(IDatabaseFactory dbFactory)
            : base(dbFactory)
        {
        }

    }
    public interface IProductRepository : IRepository<product> { }
}
