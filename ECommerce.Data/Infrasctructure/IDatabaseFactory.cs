using ECmmerce.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECmmerce.Data.Infrasctructure
{
    public interface IDatabaseFactory : IDisposable 
    { 
        ecommerceContext DataContext { get; } 
    }
}
