using HomeTaskApi.Controllers;
using HomeTaskApi.Data;
using HomeTaskApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace HomeTaskUnitTest
{
    public class CumulativeJobInfoControllerUnitTest
    {
        public CumulativeJobInfoControllerUnitTest()
        {

        }

        [Fact]
        public async Task Create_ReturnsBadRequest_GivenInvalidDates()
        {
            var dbContextMock = new Mock<HomeTaskDbContext>();
            var dbSetMock = new Mock<DbSet<CumulativeJobInfo>>();
            dbContextMock.Setup(s => s.Set<CumulativeJobInfo>()).Returns(dbSetMock.Object);
            var mockRepo = new Mock<ICumulativeJobInfoRepository>();

            mockRepo.Setup(repo => repo.GetCumulativeJobInfoByDates(It.IsAny<DateTime>(), It.IsAny<DateTime>()))
                .ReturnsAsync(GetTestJobInfo());

            var controller = new CumulativeJobInfoController(mockRepo.Object);

            // Act
            var result = await controller.GetCumulativeJobInfoByDates(new DateTime(2021, 1, 1), DateTime.Today);

            // Assert
            Assert.IsType<OkObjectResult>(result);
        }

        private List<CumulativeJobInfo> GetTestJobInfo()
        {
            var list = new List<CumulativeJobInfo>();
            list.Add(new CumulativeJobInfo
            {
                Id = 1,
                ActiveJobs = 56,
                JobViews = 64,
                PredictedJobViews = 124,
                Date = new DateTime(2021, 1, 1)
            });           

            return list;
        }
    }
}
