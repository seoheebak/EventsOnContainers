namespace WebMVC.Infrastructer
{
    public class APIPaths
    {
        public static class Event
        {
            public static string GetAllTypes(string baseUrl)
            {
                return $"{baseUrl}/eventtypes";
            }
        }
    }
}
