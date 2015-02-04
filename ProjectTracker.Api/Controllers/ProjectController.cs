using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using ProjectTracker.Core.Domain;

namespace ProjectTracker.Api.Controllers
{
     [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ProjectController : ApiController
    {
        // GET: api/Project
        public IEnumerable<Project> Get()
        {
            var p = new Project
            {
                CreatedDate = DateTime.Now,
                Name = "Boda Alberto y Maria Jose",
                Tasks = new List<Task>
                {
                    new Task
                    {
                        Name = "Casa"
                    },
                    new Task
                    {
                        Name = "Ceremonia"
                    }
                }
            };
            var p2 = new Project
            {
                CreatedDate = DateTime.Now,
                Name = "Valencia Fashion",
                Tasks = new List<Task>
                {
                    new Task
                    {
                        Name = "Sesión"
                    },
                        new Task
                    {
                        Name = "Selección"
                    },
                    new Task
                    {
                        Name = "Edición"
                    }
                }
            };
            return new Project[] { p, p2 };
        }

        // GET: api/Project/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Project
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Project/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Project/5
        public void Delete(int id)
        {
        }
    }
}
