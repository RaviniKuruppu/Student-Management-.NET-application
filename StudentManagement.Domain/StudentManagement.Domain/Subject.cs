using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Domain
{
    public class Subject
    {
        public string ID { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public ICollection<Student>? Student { get; set; }
    }
}
