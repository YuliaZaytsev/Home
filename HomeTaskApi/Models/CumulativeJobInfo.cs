using System;

namespace HomeTaskApi.Models
{
    public class CumulativeJobInfo
    {
        public int Id { get; set; }
        public int? ActiveJobs { get; set; }
        public int? JobViews { get; set; }
        public int PredictedJobViews { get; set; }
        public DateTime Date { get; set; }
    }
}
