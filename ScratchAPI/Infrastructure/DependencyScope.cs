using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http.Dependencies;
using Castle.MicroKernel.Lifestyle;
using Castle.Windsor;

namespace ScratchAPI.Infrastructure
{
    public class DependencyScope : IDependencyScope
    {
        private IWindsorContainer container;
        private IDisposable scope;

        public DependencyScope(IWindsorContainer container)
        {
            this.container = container;
            this.scope = container.BeginScope();
        }

        public void Dispose()
        {
            this.scope.Dispose();
        }

        public object GetService(Type serviceType)
        {
            return this.container.Resolve(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return this.container.ResolveAll(serviceType).Cast<object>();
        }
    }
}