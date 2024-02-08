namespace EventsWebApp.Models.EventModels
{
    public class CreateEvent
    {
        public string? Title { get; set; }

        public string? Description { get; set; }

        public DateTime? Eventdate { get; set; }

        public string? User { get; set; }
    }
}
