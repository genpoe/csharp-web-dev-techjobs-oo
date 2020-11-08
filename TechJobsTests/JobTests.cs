using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        Employer acme;
        Location desert;
        PositionType quality_control;
        CoreCompetency persistence;
        Job test_job;

        [TestInitialize]
        public void createJobObjects()
        {
            acme = new Employer("ACME");
            desert = new Location("Desert");
            quality_control = new PositionType("Quality control");
            persistence = new CoreCompetency("Persistence");
            test_job = new Job("Product tester", acme, desert, quality_control, persistence);
        }

        [TestMethod]
        public void TestSettingJobId()
        {
            Job job1 = new Job();
            Job job2 = new Job();
            Assert.IsFalse(job1.Id == job2.Id);
            Assert.IsTrue(job2.Id - job1.Id == 1);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            /*Employer acme = new Employer("ACME");
            Location desert = new Location("Desert");
            PositionType quality_control = new PositionType("Quality control");
            CoreCompetency persistence = new CoreCompetency("Persistence");
            Job test_job = new Job("Product tester", acme, desert, quality_control, persistence);*/

            Assert.AreEqual(test_job.Name, "Product tester");
            Assert.AreEqual(test_job.EmployerName, acme);
            Assert.AreEqual(test_job.EmployerLocation, desert);
            Assert.AreEqual(test_job.JobType, quality_control);
            Assert.AreEqual(test_job.JobCoreCompetency, persistence);
            Assert.AreEqual(test_job.Id, 1);
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job test_job2 = new Job("Product tester", acme, desert, quality_control, persistence);
            test_job.Equals(test_job2);
        }

        [TestMethod]
        public void TestJobsToStringForBlankLines()
        {
            Assert.IsTrue(test_job.ToString().EndsWith("\n"));
            Assert.IsTrue(test_job.ToString().StartsWith("\n"));
        }

        [TestMethod]
        public void TestJobsToStringForInformation()
        {
            string test_string = "\nID: " + test_job.Id + "\n" +
                "Name: " + test_job.Name + "\n" +
                "Employer: " + test_job.EmployerName + "\n" +
                "Location: " + test_job.EmployerLocation + "\n" +
                "Position Type: " + test_job.JobType + "\n" +
                "Core Competency: " + test_job.JobCoreCompetency + "\n";
            Assert.AreEqual(test_string, test_job.ToString());
        }

        [TestMethod]
        public void TestJobsToStringForEmptyField()
        {
            Job empty_job = new Job("", acme, desert, quality_control, persistence);
            string test_string = "\nID: " + empty_job.Id + "\n" +
                "Name: Data not available" + "\n" +
                "Employer: " + empty_job.EmployerName + "\n" +
                "Location: " + empty_job.EmployerLocation + "\n" +
                "Position Type: " + empty_job.JobType + "\n" +
                "Core Competency: " + empty_job.JobCoreCompetency + "\n";
            Assert.AreEqual(test_string, empty_job.ToString());
        }
    }
}
