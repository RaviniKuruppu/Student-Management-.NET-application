using Microsoft.EntityFrameworkCore;
using StudentManagement.Application.interfaces.Repository;
using StudentManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Infastructure
{
    public class SubjectRepository : ISubjectRepository
    {
        private readonly StudentDbContext _studentDbContext;
        public SubjectRepository(StudentDbContext studentDbContext)
        {
            _studentDbContext = studentDbContext;
        }
        public void AddSubject(Subject subject)
        {
            _studentDbContext.Subjects.Add(subject);
            //_studentDbContext.SaveChanges();
        }

        public void EditSubject(Subject subject)
        {
            var subject1 = _studentDbContext.Subjects.Where(x => x.ID == subject.ID).FirstOrDefault() ?? null;
            if (subject1 != null)
            {
                subject1.ID = subject.ID;
                subject1.Name = subject.Name;
                //_studentDbContext.SaveChanges();

            }
        }

        public Subject GetSubject(string id)
        {
            var subject = _studentDbContext.Subjects.Where(x => x.ID == id).FirstOrDefault() ?? null;
            return subject;
        }

        public List<Subject> GetSubjects()
        {
            return _studentDbContext.Subjects.ToList();
        }

        public void RemoveSubject(string id)
        {
            var subject = _studentDbContext.Subjects.Where(x => x.ID == id).FirstOrDefault() ?? null;
            _studentDbContext.Subjects.Remove(subject);
            //_studentDbContext.SaveChanges();
        }

        public List<Student> Students(string id)
        {
            var subject1=_studentDbContext.Subjects
                .Include(s=>s.Student)
                //.Where(x => x.ID == id).FirstOrDefault() ?? null;
                .Where(s => s.ID == id).SelectMany(s => s.Student).ToList();
            //var studentlist = subject1.Student;
            var studentlist = subject1;
            return studentlist.ToList();
        }
    }
}
