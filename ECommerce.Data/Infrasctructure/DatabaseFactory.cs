using ECmmerce.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//***************************************************************** SALMA **************
namespace ECmmerce.Data.Infrasctructure
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    { 
        private ecommerceContext dataContext;
        public ecommerceContext DataContext 
        { 
            get { return dataContext; }
        } 
        public DatabaseFactory() 
        {
            dataContext = new ecommerceContext();
        } 
        
        protected override void DisposeCore() 
        {
            if (DataContext != null) DataContext.Dispose(); 
        }
    }
}
