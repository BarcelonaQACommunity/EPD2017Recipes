using PageObject.Interfaces;
using Autofac;
using PageObject.Web;

namespace Container
{
    public static class AppContainer
    {
        public static IContainer Container { get; private set; }

        static AppContainer()
        {
            var buildContainer = new ContainerBuilder();
            buildContainer.RegisterType<Common>().As<ICommon>();
            buildContainer.RegisterType<AddTaskPage>().As<IAddTaskPage>();
            buildContainer.RegisterType<MainPage>().As<IMainPage>();
            Container = buildContainer.Build();
        }
    }
}
