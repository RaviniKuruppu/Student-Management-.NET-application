
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Domain
{
    public class Student
    {
        public string ID { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int Age { get; set; }
        public DateTime DOB { get; set;}
        public string Address { get; set; }= string.Empty;
        public ICollection<Subject>? Subject { get; set; }
    }
}
