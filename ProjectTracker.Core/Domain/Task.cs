using System;
using System.Collections.Generic;

namespace ProjectTracker.Core.Domain
{
    public class Task
    {
        public string Id { get; set; }
        public Project Project { get; set; }
        public string ProjectId { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public IList<Track> Tracks { get; set; }
    }
}