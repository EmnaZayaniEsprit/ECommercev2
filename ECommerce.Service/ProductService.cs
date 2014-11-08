using ECommerce.Data.Infrastructure;
using ECommerce.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Service
{
    class ProductService
    {
        static DatabaseFactory dbfactory = new DatabaseFactory();
        IUnitOfWork utow = new UnitOfWork(dbfactory);
        public List<product> getProducts()
        {
            return utow.ProductRepository.GetAll().ToList();
        }
    }
}
