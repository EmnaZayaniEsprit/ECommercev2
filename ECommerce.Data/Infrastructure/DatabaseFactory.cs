using ECommerce.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//***************************************************************** SALMA **************
namespace ECommerce.Data.Infrastructure
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    { 
        private ECommerceContext dataContext;
        public ECommerceContext DataContext 
        { 
            get { return dataContext; }
        } 
        public DatabaseFactory() 
        {
            dataContext = new ECommerceContext();
        } 
        
        protected override void DisposeCore() 
        {
            if (DataContext != null) DataContext.Dispose(); 
        }
    }
}
