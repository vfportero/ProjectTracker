using System;
using System.Collections.Generic;

namespace ProjectTracker.Core.Domain
{
    public class Project
    {
        public string Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Name { get; set; }
        public IList<Task> Tasks { get; set; }
    }
}
