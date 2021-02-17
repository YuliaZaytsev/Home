using HomeTaskApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeTaskApi.Data
{
    public class CumulativeJobInfoRepository : ICumulativeJobInfoRepository
    {
        private readonly HomeTaskDbContext _dbContext;

        public CumulativeJobInfoRepository(HomeTaskDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<CumulativeJobInfo>> GetCumulativeJobInfoByDates(DateTime from, DateTime to)
        {
            try
            {
                return await _dbContext.CumulativeJobInfoSet.Where(x => x.Date >= from && x.Date <= to).ToListAsync();
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
