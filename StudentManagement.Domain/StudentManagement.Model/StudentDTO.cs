using StudentManagement.Domain;

namespace StudentManagement.Model
{
    public class StudentDTO
    {
        public string ID { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        
        public int Age { get; set; }
        public string? DOB { get; set; }
        public string Address { get; set; } = string.Empty;

    }
}
