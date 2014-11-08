using ECmmerce.Data.Infrasctructure;
using ECmmerce.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECmmerce.Data.Infrastructure
{
    public class CreditCardRepository: RepositoryBase<creditcard>, ICreditCardRepository
    {
        public CreditCardRepository(IDatabaseFactory dbFactory)
            : base(dbFactory)
        {
        }

    }
    public interface ICreditCardRepository : IRepository<creditcard> { }
}
