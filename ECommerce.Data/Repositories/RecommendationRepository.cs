﻿using ECmmerce.Data.Infrasctructure;

using ECmmerce.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECmmerce.Data.Infrastructure
{
   public class RecommendationRepository : RepositoryBase<recommendation>,IRecommendationRepository
    {
               public RecommendationRepository(IDatabaseFactory dbFactory)
            : base(dbFactory)
        {
        }

    }
    public interface IRecommendationRepository :IRepository<recommendation>{}
}
