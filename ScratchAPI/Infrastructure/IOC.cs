using Castle.Windsor;

namespace ScratchAPI.Infrastructure
{
    public static class IOC
    {

        public static T Resolve<T>()
        {
            return container.Resolve<T>();
        }

        public static IWindsorContainer container;
    }
}