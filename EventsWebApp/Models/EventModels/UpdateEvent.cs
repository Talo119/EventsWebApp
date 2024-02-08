﻿namespace EventsWebApp.Models.EventModels
{
    public class UpdateEvent
    {
        public int Id { get; set; }

        public string? Title { get; set; }

        public string? Description { get; set; }
        public DateTime? Eventdate { get; set; }

        public string? User { get; set; }
    }
}
