
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

            internal static string GetAllEvent(string baseUrl, int page, int size, int? type)
            {
                throw new NotImplementedException();
            }
        }
    }
}
