using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StudentManagement.Application.interfaces.Services;
using StudentManagement.Application.Services;
using StudentManagement.Domain;
using StudentManagement.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        private ISubjectServices _subjectServices;
        private readonly IMapper _mapper;

        public SubjectController(ISubjectServices subjectService, IMapper mapper)
        {
            _subjectServices = subjectService;
            _mapper = mapper;
        }

        // GET: api/<SubjectController>
        [HttpGet]
        public ActionResult<List<SubjectDTO>> Get()
        {
            var subjectList = _subjectServices.GetSubjects();
            var subjectDTO = _mapper.Map<List<SubjectDTO>>(subjectList);
            return Ok(subjectDTO);
        }

        // GET api/<SubjectController>/5
        [HttpGet("{id}")]
        public ActionResult Get(string id)
        {
            var subject = _subjectServices.GetSubject(id);
            var subjectDTO = _mapper.Map<SubjectDTO>(subject);
            return Ok(subjectDTO);
        }

        // POST api/<SubjectController>
        [HttpPost]
        [Route("Creates")]
        public void Post(SubjectDTO subject)
        {
            var createSubject = _mapper.Map<Subject>(subject);
            _subjectServices.AddSubject(createSubject);
        }

        // PUT api/<SubjectController>/5
        [HttpPut]
        public void Put(SubjectDTO subject)
        {
            var updateSubject = _mapper.Map<Subject>(subject);
            _subjectServices.EditSubject(updateSubject);
        }


        // DELETE api/<StudentController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            _subjectServices.RemoveSubject(id);
        }

        // GET api/<SubjectController>/5
        [HttpGet("StudentList/{id}")]
        public ActionResult<List<StudentDTO>> StudentList(string id)
        {
            var studentList = _subjectServices.Students(id);
            var studentDTO = _mapper.Map<List<StudentDTO>>(studentList);
            return Ok(studentDTO);
        }



    }
}
