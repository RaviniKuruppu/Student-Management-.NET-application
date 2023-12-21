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
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        private IUnitOfWork _unitOfWork;

        public StudentService(IStudentRepository studentRepository, IUnitOfWork unitOfWork)
        {
            _studentRepository = studentRepository;
            _unitOfWork = unitOfWork;
        }
        public List<Student> GetAllStudent()
        {
           //return _studentRepository.GetAllStudent();
           return _unitOfWork.studentRepository.GetAllStudent();
        }

        public void AddStudent(Student student)
        {
            //_studentRepository.AddStudent(student);
            _unitOfWork.studentRepository.AddStudent(student);
            _unitOfWork.SaveChanges();
        }

        public void DeleteStudent(string id)
        {
            //_studentRepository.DeleteStudent(id);
            _unitOfWork.studentRepository.DeleteStudent(id);
            _unitOfWork.SaveChanges();
        }

        

        public Student GetStudent(string id)
        {
            
            //return _studentRepository.GetStudent(id);
            return _unitOfWork.studentRepository.GetStudent(id);
            
        }

        public void UpdateStudent(Student student)
        {
            //_studentRepository.UpdateStudent(student);
            _unitOfWork.studentRepository.UpdateStudent(student);
            _unitOfWork.SaveChanges();
        }

      

        public List<Subject> GetSubjectList(string id)
        {
            //return _studentRepository.GetSubjectList(id);
            return _unitOfWork.studentRepository.GetSubjectList(id);
        }

        public void AssignSubject(string StudentID, string SubjectID)
        {
            //_studentRepository.AssignSubject(StudentID, SubjectID);
            _unitOfWork.studentRepository.AssignSubject(StudentID, SubjectID);
            _unitOfWork.SaveChanges();
        }

        public void UnassignSubject(string StudentID, string SubjectID)
        {
            //_studentRepository.UnassignSubject(StudentID, SubjectID);   
            _unitOfWork.studentRepository.UnassignSubject(StudentID, SubjectID);
            _unitOfWork.SaveChanges();
        }
    }
}
