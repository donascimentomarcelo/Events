namespace Events.API.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public string Local { get; set; }
        public string DateEvent { get; set; }
        public string Theme { get; set; }
        public int QuantityPeople { get; set; }
        public string Allotment { get; set; }
        public string ImageURL { get; set; }
    }
}