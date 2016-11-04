using System.Net.Http;
using System.Web.Http;

namespace ScratchAPI.Controllers
{

    public class Coordinate
    {
        public double Lattitude { get; set; }
        public double Longitude { get; set; }
    }

    public class CoordinatesController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage Post([FromUri] Coordinate coordinates) => Request.CreateResponse(coordinates);
    }
}
