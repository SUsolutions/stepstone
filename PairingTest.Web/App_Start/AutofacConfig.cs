using Autofac;
using Autofac.Integration.Mvc;
using PairingTest.Web.Services;
using System.Web;
using System.Web.Mvc;

namespace PairingTest.Web.App_Start
{
    public class AutofacConfig
    {
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            builder.RegisterType<QuestionnaireService>().As<IQuestionnaireService>();




            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}