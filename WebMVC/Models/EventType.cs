namespace WebMVC.Models
{
    public class EventType
    {
        public int Pageindex { get; set; }
        public int Pagesize { get; set; }

        public long Pagecount { get; set; }
        public IEnumerable <EventType> Data { get; set; }
    }
}
