using Castle.Windsor;

namespace ScratchAPI.Infrastructure
{
    public static class Bootstrapper
    {

        public static void Start()
        {
            var container = new WindsorContainer();
            container.Install(new ApiInstaller());
            container.Install(new RepositoryInstaller());

            IOC.container = container;
        }
        
    }
}