using StudentManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Application.interfaces.Services
{
    // Implement Bussiness Rule / USE CASES
    public interface IStudentService
    {
        void AddStudent(Student student);
        void UpdateStudent(Student student);
        void DeleteStudent(string id);

        Student GetStudent(string id);
        List<Student> GetAllStudent();

        List<Subject> GetSubjectList(string id);
        void AssignSubject(string StudentID, string SubjectID);
        void UnassignSubject(string StudentID, string SubjectID);
    }
}
