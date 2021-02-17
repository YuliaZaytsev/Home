using HomeTaskApi.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace HomeTaskApi.Data
{
    public class HomeTaskDbContext : DbContext
    {
        public DbSet<CumulativeJobInfo> CumulativeJobInfoSet { get; set; }
        public HomeTaskDbContext(DbContextOptions<HomeTaskDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CumulativeJobInfo>(entity => { entity.Property(e => e.Id).IsRequired(); });

            #region CumulativeJobInfoSeed

            modelBuilder.Entity<CumulativeJobInfo>().HasData(
                new CumulativeJobInfo { Id = 1, ActiveJobs = 32, JobViews = 123, PredictedJobViews = 210, Date = new DateTime(2021, 1, 20) },
                new CumulativeJobInfo { Id = 2, ActiveJobs = 12, JobViews = 89, PredictedJobViews = 165, Date = new DateTime(2021, 1, 21) },
                new CumulativeJobInfo { Id = 3, ActiveJobs = 44, JobViews = 110, PredictedJobViews = 189, Date = new DateTime(2021, 1, 22) },
                new CumulativeJobInfo { Id = 4, ActiveJobs = 31, JobViews = 105, PredictedJobViews = 201, Date = new DateTime(2021, 1, 23) },
                new CumulativeJobInfo { Id = 5, ActiveJobs = 45, JobViews = 79, PredictedJobViews = 187, Date = new DateTime(2021, 1, 24) },
                new CumulativeJobInfo { Id = 6, ActiveJobs = 24, JobViews = 84, PredictedJobViews = 165, Date = new DateTime(2021, 1, 25) },
                new CumulativeJobInfo { Id = 7, ActiveJobs = 38, JobViews = 90, PredictedJobViews = 200, Date = new DateTime(2021, 1, 26) },
                new CumulativeJobInfo { Id = 8, ActiveJobs = 27, JobViews = 120, PredictedJobViews = 194, Date = new DateTime(2021, 1, 27) },
                new CumulativeJobInfo { Id = 9, ActiveJobs = 35, JobViews = 93, PredictedJobViews = 173, Date = new DateTime(2021, 1, 28) },
                new CumulativeJobInfo { Id = 10, ActiveJobs = 28, JobViews = 75, PredictedJobViews = 165, Date = new DateTime(2021, 1, 29) },
                new CumulativeJobInfo { Id = 11, ActiveJobs = 39, JobViews = 119, PredictedJobViews = 203, Date = new DateTime(2021, 1, 30) },
                new CumulativeJobInfo { Id = 12, ActiveJobs = 42, JobViews = 125, PredictedJobViews = 210, Date = new DateTime(2021, 1, 31) },
                new CumulativeJobInfo { Id = 13, ActiveJobs = 47, JobViews = 143, PredictedJobViews = 189, Date = new DateTime(2021, 2, 1) },
                new CumulativeJobInfo { Id = 14, ActiveJobs = 36, JobViews = 100, PredictedJobViews = 199, Date = new DateTime(2021, 2, 2) },
                new CumulativeJobInfo { Id = 15, ActiveJobs = 24, JobViews = 110, PredictedJobViews = 175, Date = new DateTime(2021, 2, 3) },
                new CumulativeJobInfo { Id = 16, ActiveJobs = 35, JobViews = 120, PredictedJobViews = 179, Date = new DateTime(2021, 2, 4) },
                new CumulativeJobInfo { Id = 17, ActiveJobs = 46, JobViews = 130, PredictedJobViews = 135, Date = new DateTime(2021, 2, 5) },
                new CumulativeJobInfo { Id = 18, ActiveJobs = null, JobViews = null, PredictedJobViews = 145, Date = new DateTime(2021, 2, 6) },
                new CumulativeJobInfo { Id = 19, ActiveJobs = null, JobViews = null, PredictedJobViews = 165, Date = new DateTime(2021, 2, 7) },
                new CumulativeJobInfo { Id = 20, ActiveJobs = null, JobViews = null, PredictedJobViews = 185, Date = new DateTime(2021, 2, 8) });

            #endregion

        }
    }
}
