namespace api_project.webApi.Entities
{
    public class Review
    {

        public int ReviewId { get; set; }
        public string NameSurname { get; set; }
        public string Title { get; set; }
        public string Comment { get; set; }
        public string ImageUrl { get; set; }
    }
}
