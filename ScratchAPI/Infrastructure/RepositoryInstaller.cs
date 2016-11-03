using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace ScratchAPI.Infrastructure
{
    public class RepositoryInstaller : IWindsorInstaller {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                Classes.FromThisAssembly()
                    .Where(x => x.Name.EndsWith("Repository"))
                    .WithService.DefaultInterfaces()
                    .LifestyleTransient());
        }
    }
}