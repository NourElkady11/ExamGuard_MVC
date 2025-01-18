using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services;
using Services.Abstraction;

namespace Presentation_Layer.Controllers
{
    public class StudentController(IExamService examService,IServiceManger serviceManger) : Controller
    {
        [Authorize(Roles = "Student")]

        public async Task<IActionResult> Index()
        {
            var exams = await serviceManger.examService.GetExams();
            return View(exams);
           
        }

        public async Task<IActionResult> GetAllGrades()
        {
            return View();
        }
    }
}
