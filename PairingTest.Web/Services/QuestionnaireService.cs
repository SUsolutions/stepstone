using PairingTest.Web.Models;
using System.Net.Http;

namespace PairingTest.Web.Services
{
    public class QuestionnaireService : IQuestionnaireService
    {
        public QuestionnaireViewModel getQuestionnaire()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new System.Uri("http://localhost:50014");
            HttpResponseMessage response = client.GetAsync("api/questions").Result;

            QuestionnaireViewModel questionnaireVM = new QuestionnaireViewModel();
            if (response.IsSuccessStatusCode)
            {
                questionnaireVM = response.Content.ReadAsAsync<QuestionnaireViewModel>().Result;
            }

            return questionnaireVM;
        }
    }
}