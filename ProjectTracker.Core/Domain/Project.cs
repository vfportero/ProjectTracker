using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Proxies;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.Core.Domain
{
    public class Project
    {
        public string Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Name { get; set; }
        public IList<Task> Tasks { get; set; }
    }

    public class Task
    {
        public string Id { get; set; }
        public Project Project { get; set; }
        public string ProjectId { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public IList<Track> Tracks { get; set; }
    }

    public class Track
    {
        public string Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Task Task { get; set; }
        public string TaskId { get; set; }
        
    }
}
