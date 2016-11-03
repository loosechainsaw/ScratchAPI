using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http.Dependencies;

namespace ScratchAPI.Infrastructure
{
    public class DependencyResolver : IDependencyResolver
    {
        public IDependencyScope BeginScope()
        {
            return new DependencyScope(IOC.container);
        }

        public void Dispose()
        {

        }

        public object GetService(Type serviceType)
        {
            return IOC.container.Kernel.HasComponent(serviceType) ? IOC.container.Resolve(serviceType) : null;
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return IOC.container.Kernel.HasComponent(serviceType)
                ? IOC.container.ResolveAll(serviceType).Cast<object>()
                : new List<object>();
        }
    }
}