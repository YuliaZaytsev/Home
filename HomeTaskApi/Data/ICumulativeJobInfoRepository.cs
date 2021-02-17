using HomeTaskApi.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HomeTaskApi.Data
{
    public interface ICumulativeJobInfoRepository
    {
        Task<List<CumulativeJobInfo>> GetCumulativeJobInfoByDates(DateTime from, DateTime to);
    }
}
