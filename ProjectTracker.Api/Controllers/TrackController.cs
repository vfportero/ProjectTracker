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
    public class TrackController : ApiController
    {
        [HttpGet]
        public Track Current()
        {
            return new Track()
                   {
                       StartDate = new DateTime(2015, 2, 5, 9, 0, 0),
                       Task = new Task
                              {
                                  Name = "Convite",
                                  Project = new Project
                                            {
                                                Name = "Boda Alberto y Maria Jose"
                                            }
                              }
                   };
        }
    }
}
