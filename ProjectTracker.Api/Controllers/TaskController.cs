using System.Web.Http;
using System.Web.Http.Cors;
using ProjectTracker.Core.Domain;

namespace ProjectTracker.Api.Controllers
{
         [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class TaskController : ApiController
    {
       
    }
}
