using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.

        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }

        // TODO: Generate Equals() and GetHashCode() methods.
        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            string str = "\n";
            List<string> job_info = new List<string> { this.Id.ToString(), this.Name.ToString(), this.EmployerName.ToString(),
                this.EmployerLocation.ToString(), this.JobType.ToString(), this.JobCoreCompetency.ToString() };

            for (int i = 0; i < job_info.Count; i++)
            {
                switch (i)
                {
                    case 0:
                        str += "ID: ";
                        break;
                    case 1:
                        str += "Name: ";
                        break;
                    case 2:
                        str += "Employer: ";
                        break;
                    case 3:
                        str += "Location: ";
                        break;
                    case 4:
                        str += "Position Type: ";
                        break;
                    case 5:
                        str += "Core Competency: ";
                        break;
                }

                if (job_info[i] == "")
                {
                    str += "Data not available";
                } else
                {
                    str += job_info[i];
                }

                str += "\n";
            }

            return str;
        }
    }
}
