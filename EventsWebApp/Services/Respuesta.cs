using System.Collections;

namespace EventsWebApp.Services
{
    public class Respuesta
    {
        public bool Status { get; set; }
        public IEnumerable Data { get; set; }
        public string Message { get; set; }
        public object Objeto { get; set; }
        public string Detail { get; set; }
    }
}
