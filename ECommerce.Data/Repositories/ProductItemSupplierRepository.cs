using ECmmerce.Data.Infrasctructure;

using ECmmerce.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECmmerce.Data.Infrastructure
{
   public class ProductItemSupplierRepository : RepositoryBase<productitemsupplier>,IProductItemSupplierRepository
    {
               public ProductItemSupplierRepository(IDatabaseFactory dbFactory)
            : base(dbFactory)
        {
        }

    }

   public interface IProductItemSupplierRepository : IRepository<productitemsupplier> { }
}
