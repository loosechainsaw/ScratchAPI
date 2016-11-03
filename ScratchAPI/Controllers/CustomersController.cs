using System.Net;
using System.Net.Http;
using System.Web.Http;
using ScratchAPI.Repositories;

namespace ScratchAPI.Controllers
{
    public class CustomersController: ApiController
    {
        public CustomersController(ICustomerRepository repository)
        {
            this.repository = repository;
        }

        public HttpResponseMessage Get() => Request.CreateResponse(HttpStatusCode.OK, this.repository.GetAll());
        private readonly ICustomerRepository repository;
    }
}