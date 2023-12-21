using StudentManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Application.interfaces.Repository
{
    public interface ISubjectRepository
    {
        void AddSubject(Subject subject);
        void RemoveSubject(string id);
        void EditSubject(Subject subject);
        List<Subject> GetSubjects();
        Subject GetSubject(string id);

        List<Student> Students(string id);



    }
}
