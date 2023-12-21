using Microsoft.EntityFrameworkCore;
using StudentManagement.Application.interfaces.Repository;
using StudentManagement.Application.interfaces.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Infastructure
{
    public class UnitOfWork:IUnitOfWork
    {
        private StudentDbContext _dbContext;
        private IStudentRepository _studentRepository;   
        private ISubjectRepository _subjectRepository;
        public UnitOfWork(StudentDbContext dbContext,IStudentRepository studentRepository,ISubjectRepository subjectRepository) {
            _dbContext = dbContext;
            _studentRepository = studentRepository;
            _subjectRepository = subjectRepository;
        }

        public IStudentRepository studentRepository {
            get { return _studentRepository ??= new StudentRepository(_dbContext); }
            set { _studentRepository = value; }
        }
        public ISubjectRepository subjectRepository 
        {
            get { return _subjectRepository ??= new SubjectRepository(_dbContext); }
            set { _subjectRepository = value; }
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }
    }
}
