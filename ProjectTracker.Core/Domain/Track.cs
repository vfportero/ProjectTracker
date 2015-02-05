using System;

namespace ProjectTracker.Core.Domain
{
    public class Track
    {
        public string Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Task Task { get; set; }
        public string TaskId { get; set; }
        
    }
}