using System;
using System.Text.Encodings.Web;

namespace TechJobsOO
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job job2 = new Job("Web Developer", new Employer("LaunchCode"), new Location("St. Louis"), new PositionType("Front-end developer"), new CoreCompetency("JavaScript"));
            Job job3 = new Job("Ice cream tester", new Employer(""), new Location("Home"), new PositionType("UX"), new CoreCompetency("Tasting ability"));

            List<Job> jobs = new List<Job>();

            jobs.Add(job1);
            jobs.Add(job2);
            jobs.Add(job3);

            foreach (Job job in jobs)
            {
                Console.WriteLine(job);
            }
            */

            //above was already writen, I added below while I was Unit Testing

/*            Employer acme = new Employer("ACME");
            Location desert = new Location("Desert");
            PositionType quality_control = new PositionType("Quality control");
            CoreCompetency persistence = new CoreCompetency("Persistence");
            Job test_job = new Job("Product tester", acme, desert, quality_control, persistence);
            Job test_job2 = new Job("Product tester", acme, desert, quality_control, persistence);*/
            //Console.WriteLine(test_job.ToString());

           /* string test_string = "\nID: 1\n" +
                "Name: Product tester\n" +
                "Employer: ACME\n" +
                "Location: Desert\n" +
                "Position Type: Quality control\n" +
                "Core Competency: Persistence\n";
            Console.WriteLine(test_string);*/
        }
    }
}
