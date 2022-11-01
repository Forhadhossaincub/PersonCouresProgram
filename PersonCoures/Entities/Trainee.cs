using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonCoures.Entities
{
    public sealed class Trainee : Person,ISubjects
    {
        public Trainee() { this.Subjects = new List<string>(); }
        public Trainee(int id, string name, string address, DateTime dob, Course course) : base( name,address,dob )
        {
            this.ID = id;
            this.Course = course;
            this.Subjects = new List<string>();
        }

        public int ID { get; set; } 
        public Course Course { get; set; }
        private List<string> Subjects { get; set; }

        public override int Age()
        {
            return DateTime.Now.Year - DateOfBirth.Year;
        }
        public void AddSubjects(string[] subject)
        {
            this.Subjects.AddRange(subject);
        }
        public string GetSubjects()
        {
          return String.Join(",", Subjects.ToArray());
        }
    }
}
