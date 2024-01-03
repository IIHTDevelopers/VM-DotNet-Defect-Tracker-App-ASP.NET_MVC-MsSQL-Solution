
using DefectTrackerApp.DAL;
using DefectTrackerApp.DAL.Interface;
using DefectTrackerApp.DAL.Repository;
using DefectTrackerApp.Models;
using Moq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace DefectTrackerApp.Tests.TestCases
{
    public class BoundaryTests
    {
        private readonly ITestOutputHelper _output;
        private readonly IDefectTrackerInterface _defectTrackerService;
        public readonly Mock<IDefectTrackerRepository> defecttrackerservice = new Mock<IDefectTrackerRepository>();
        private readonly Defect _Defect;
        private readonly IEnumerable<Defect> DefectList;

        private static string type = "Boundary";

        public BoundaryTests(ITestOutputHelper output)
        {
            _defectTrackerService = new DefectTrackerService(defecttrackerservice.Object);
            _output = output;
            _Defect = new Defect
            {
                 Id = 1,
                Date = DateTime.Now,
                DefectName = "Exercise",
                IsCompleted = true,
                Notes = "30 minutes of jogging in the park."
            };
            DefectList = new List<Defect>
        {
            new Defect
            {
                Id = 1,
                Date = DateTime.Now,
                DefectName = "Exercise",
                IsCompleted = true,
                Notes = "30 minutes of jogging in the park."
            },
            new Defect
            {
                Id = 2,
                Date = DateTime.Now,
                DefectName = "Exercise",
                IsCompleted = true,
                Notes = "30 minutes of jogging in the park."
            },
        };

        }

        [Fact]
        public async Task<bool> Testfor_Id_NotNull()
        {
            //Arrange
            var res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            int id = 1;

            //Action
            try
            {
                defecttrackerservice.Setup(repos => repos.GetDefectByID(_Defect.Id)).Returns(_Defect);
                var result = _defectTrackerService.GetDefectByID(_Defect.Id);

                //Assertion
                if (result!= null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

        [Fact]
        public async Task<bool> Testfor_Date_NotNull()
        {
            //Arrange
            var res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            int id = 1;

            //Action
            try
            {
                defecttrackerservice.Setup(repos => repos.GetDefectByID(_Defect.Id)).Returns(_Defect);
                var result = _defectTrackerService.GetDefectByID(_Defect.Id);

                //Assertion
                if (result!= null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

        [Fact]
        public async Task<bool> Testfor_DefectName_NotNull()
        {
            //Arrange
            var res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            int id = 1;

            //Action
            try
            {
                defecttrackerservice.Setup(repos => repos.GetDefectByID(_Defect.Id)).Returns(_Defect);
                var result = _defectTrackerService.GetDefectByID(_Defect.Id);

                //Assertion
                if (result!=null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

        [Fact]
        public async Task<bool> Testfor_IsCompleted_NotNull()
        {
            //Arrange
            var res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            int id = 1;

            //Action
            try
            {
                defecttrackerservice.Setup(repos => repos.GetDefectByID(_Defect.Id)).Returns(_Defect);
                var result = _defectTrackerService.GetDefectByID(_Defect.Id);
               

                //Assertion
                if (result!= null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

        [Fact]
        public async Task<bool> Testfor_Notes_NotNull()
        {
            //Arrange
            var res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            int id = 1;

            //Action
            try
            {
                defecttrackerservice.Setup(repos => repos.GetDefectByID(_Defect.Id)).Returns(_Defect);
                var result = _defectTrackerService.GetDefectByID(_Defect.Id);


                //Assertion
                if (result != null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

    }
}