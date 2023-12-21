using Microsoft.EntityFrameworkCore;
using StudentManagement.Application.interfaces.Repository;
using StudentManagement.Domain;
//using StudentManagement.Model;
using System.Net.Cache;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;

namespace StudentManagement.Infastructure
{
    public class StudentRepository : IStudentRepository
    {
        private readonly StudentDbContext _studentDbContext;
        public StudentRepository(StudentDbContext studentDbContext) 
        {
            _studentDbContext = studentDbContext;
        }
        public void AddStudent(Student student)
        {
            _studentDbContext.Students.Add(student);
            //_studentDbContext.SaveChanges();
        }

        

        public void DeleteStudent(string id)
        {
            var student = _studentDbContext.Students.Where(x => x.ID == id).FirstOrDefault() ?? null;
            _studentDbContext.Students.Remove(student);
            //_studentDbContext.SaveChanges(true);
        }

        public List<Student> GetAllStudent()
        {
            return _studentDbContext.Students.ToList();
        }

        public Student GetStudent(string id)
        {
            var student = _studentDbContext.Students.Where(x => x.ID == id).FirstOrDefault() ?? null;
            return student;
        }

        public List<Subject> GetSubjectList(string id)
        {
            var student1 = _studentDbContext.Students
                .Include(s => s.Subject)
                //.Where(x => x.ID == id).FirstOrDefault() ?? null;
                .Where(s => s.ID == id).SelectMany(s => s.Subject).ToList();
            var subjectList = student1;
            return subjectList.ToList();
        }

        public void UpdateStudent(Student student)
        {
            var student1 = _studentDbContext.Students.Where(x => x.ID == student.ID).FirstOrDefault() ?? null;
            if (student1 != null)
            {
                student1.ID = student.ID;
                student1.FirstName = student.FirstName;
                student1.LastName = student.LastName;
                student1.Address = student.Address;
                student1.Age = student.Age;
                student1.DOB = student.DOB;
                //_studentDbContext.SaveChanges();
            }
            else
            {
                throw new Exception();
            }

        }

        public void UnassignSubject(string StudentID, string SubjectID)
        {
            var student1 = _studentDbContext.Students.Where(x => x.ID == StudentID).FirstOrDefault() ?? null;
            var subject1 = _studentDbContext.Subjects.Where(x => x.ID == SubjectID).FirstOrDefault() ?? null;
            if (student1 != null && subject1 != null) 
            {

                var user = _studentDbContext.Students.Include(x => x.Subject).Single(x => x.ID == StudentID); 

                var channelToRemove = user.Subject.SingleOrDefault(x => x.ID == SubjectID); 

                if (channelToRemove != null)
                    user.Subject.Remove(channelToRemove);

                //_studentDbContext.SaveChanges();
            }
            

        }

        public void AssignSubject(string StudentID, string SubjectID)
        {
            var student1 = _studentDbContext.Students.Where(x => x.ID == StudentID).FirstOrDefault() ?? null;
            var subject1 = _studentDbContext.Subjects.Where(x => x.ID == SubjectID).FirstOrDefault() ?? null;
            if (student1 != null && subject1 != null)
            {
                student1.Subject ??= new List<Subject>();
                student1.Subject.Add(subject1);
                //_studentDbContext.SaveChanges(true);

            }
        }


    }
}
