using StudentManagement.Application.interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Application.interfaces.UnitOfWork
{
    public interface IUnitOfWork
    {
        IStudentRepository studentRepository { get; set; }
        ISubjectRepository subjectRepository { get; set; }
        void SaveChanges();
    }
}
