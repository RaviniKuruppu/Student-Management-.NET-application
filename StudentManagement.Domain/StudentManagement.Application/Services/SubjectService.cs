using StudentManagement.Application.interfaces.Repository;
using StudentManagement.Application.interfaces.Services;
using StudentManagement.Application.interfaces.UnitOfWork;
using StudentManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Application.Services
{
    public class SubjectService : ISubjectServices
    {
        private readonly ISubjectRepository _subjectRepository;
        private IUnitOfWork _unitOfWork;

        public SubjectService(ISubjectRepository subjectRepository, IUnitOfWork unitOfWork)
        {
            _subjectRepository = subjectRepository;
            _unitOfWork = unitOfWork;
        }

        public void AddSubject(Subject subject)
        {
            //_subjectRepository.AddSubject(subject);
            _unitOfWork.subjectRepository.AddSubject(subject);
            _unitOfWork.SaveChanges();
        }

        public void EditSubject(Subject subject)
        {
            //_subjectRepository.EditSubject(subject);
            _unitOfWork.subjectRepository.EditSubject(subject);
            _unitOfWork.SaveChanges();
        }

        public Subject GetSubject(string id)
        {
            //return _subjectRepository.GetSubject(id);
            return _unitOfWork.subjectRepository.GetSubject(id);
        }

        
        public List<Subject> GetSubjects()
        {
           //return _subjectRepository.GetSubjects();
           return _unitOfWork.subjectRepository.GetSubjects();
        }

        public void RemoveSubject(string id)
        {
            //_subjectRepository.RemoveSubject(id);
            _unitOfWork.subjectRepository.RemoveSubject(id);
            _unitOfWork.SaveChanges();
        }

        public List<Student> Students(string id)
        {
            //return _subjectRepository.Students(id);
            return _unitOfWork.subjectRepository.Students(id);
        }
    }
}
