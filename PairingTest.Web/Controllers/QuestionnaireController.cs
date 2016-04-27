using System.Web.Mvc;
using PairingTest.Web.Models;
using PairingTest.Web.Services;

namespace PairingTest.Web.Controllers
{
    public class QuestionnaireController : Controller
    {
        private readonly IQuestionnaireService _questionnaireService;
        public QuestionnaireController(IQuestionnaireService questionnaireService)
        {
            _questionnaireService = questionnaireService;
        }

          /* ASYNC ACTION METHOD... IF REQUIRED... */
//        public async Task<ViewResult> Index()
//        {
//        }

        public ViewResult Index()
        {
            QuestionnaireViewModel questionnaireVM = _questionnaireService.getQuestionnaire();

            return View(questionnaireVM);
        }
    }
}
