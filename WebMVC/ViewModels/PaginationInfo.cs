namespace WebMVC.ViewModels
{
    public class PaginationInfo
    {
        public long TotalTypes {  get; set; }
        public int TypesPerPage {  get; set; }
        public int ActualPage {  get; set; }   
        public int TotalPages {  get; set; }
        public string Previous {  get; set; }
        public string Next { get; set; }

    }
}
