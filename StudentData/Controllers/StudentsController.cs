
using Student;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Student.Business.Business;
using Student.Model;

namespace StudentData.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentBusiness _StudentBusiness;
        public StudentsController(IStudentBusiness StudentBusiness)
        {
            _StudentBusiness = StudentBusiness;
        }
        [HttpGet]
        public int GetTotalMarkObtainedByid(int id)
        {
            return _StudentBusiness.GetTotalMarkObtainedByid(id);

        }
        [HttpGet]
        public IEnumerable<Marksheet> GetAllMarksByStudentId(int StudentId) => _StudentBusiness.GetAllMarksByStudentId(StudentId);
        [HttpPost]
        public IActionResult AddMarks(Marksheet mark)
        {
            _StudentBusiness.AddMarks(mark);
            return Ok(mark);
        }
        [HttpPut]
        public ActionResult UpdateMarks(Marksheet mark)
        {
            bool res = StudentBusiness.UpdateMarks(mark);
            if (!res) return NoContent();

            return Ok();
        }
    }
}
