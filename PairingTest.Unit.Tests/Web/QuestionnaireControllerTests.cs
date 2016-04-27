using Moq;
using NUnit.Framework;

using PairingTest.Web.Controllers;
using PairingTest.Web.Models;
using PairingTest.Web.Services;

namespace PairingTest.Unit.Tests.Web
{
    [TestFixture]
    public class QuestionnaireControllerTests
    {
        [Test]
        public void ShouldGetQuestions()
        {
            //Arrange
            var expectedTitle = "My expected questions";
            var mock = new Mock<IQuestionnaireService>();
            mock.Setup(service => service.getQuestionnaire())
                .Returns(new QuestionnaireViewModel { QuestionnaireTitle = expectedTitle });
            var questionnaireController = new QuestionnaireController(mock.Object);

            //Act
            var result = (QuestionnaireViewModel)questionnaireController.Index().ViewData.Model;

            //Assert
            Assert.That(result.QuestionnaireTitle, Is.EqualTo(expectedTitle));
        }
    }
}