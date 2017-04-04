using Core.Data;
using Domain;
using In.IData;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace In.Data
{
    public class WeightRecordRepository : Repository<WeightRecord,long> , IWeightRecordRepository
    {
        public WeightRecordRepository(DbContext dbContext)
            : base(dbContext)
        {

        }
    }
}
