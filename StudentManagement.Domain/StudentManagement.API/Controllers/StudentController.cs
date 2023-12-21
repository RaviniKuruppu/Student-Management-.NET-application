using Microsoft.AspNetCore.Mvc;
using StudentManagement.Application.interfaces.Services;
using StudentManagement.Application.Services;
using StudentManagement.Domain;
using StudentManagement.Model;
using System.Text.Json.Serialization;
using System.Text.Json;
using AutoMapper;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        private readonly IMapper _mapper;
        public StudentController(IStudentService studentService, IMapper mapper)
        {
            _studentService= studentService;
            _mapper= mapper;
        }

        // GET: api/<StudentController>
        [HttpGet]
        public ActionResult<List<StudentDTO>> Get()
        {
             var studentList = _studentService.GetAllStudent(); 
             var studentDTO=_mapper.Map<List<StudentDTO>>(studentList);
             return Ok(studentDTO);

        }


        // POST api/<StudentController>
        [HttpPost]
        [Route("Creates")]
        public void Post(StudentCreateDTO student)
        {
            var createStudent=_mapper.Map<Student>(student);
            _studentService.AddStudent(createStudent);
        }



        // PUT api/<StudentController>/5
        [HttpPut]
        public void Put(StudentCreateDTO student)
        {
            var updateStudent = _mapper.Map<Student>(student);
            _studentService.UpdateStudent(updateStudent);
        }

        // DELETE api/<StudentController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            _studentService.DeleteStudent(id);
        }

        // GET api/<StudentController>/5
        [HttpGet("{id}")]
        public ActionResult Get(string id)
        {
            var student = _studentService.GetStudent(id);

            var studentDTO = _mapper.Map<StudentCreateDTO>(student);    
            return Ok(studentDTO);
        }

        // GET api/<StudentController>/5
        [HttpGet("SubjectList/{id}")]
        public ActionResult<List<SubjectDTO>> SubjectList(string id)
        {
            List<Subject> subjectList = _studentService.GetSubjectList(id);
            var subjectDTO = _mapper.Map<List<SubjectDTO>>(subjectList);
            return Ok(subjectDTO);
            
        }
        
        
        [HttpPost("AssignSubject")]
        public void AssignSubject([FromBody] EnrollmentDTO request)
        {
            _studentService.AssignSubject(request.StudentID, request.SubjectID);
        }
        

        [HttpPost("UnassignSubject")]
        public void UnassignSubject([FromBody] EnrollmentDTO request)
        {
            _studentService.UnassignSubject(request.StudentID, request.SubjectID);
        }


    }
}
