namespace backend.Models
{
    public class Review
    {
        public long ReviewId { get; set; }
        public long BookId { get; set; }
        public string Author { get; set; }
        public string Comment { get; set; }
        public int Rating { get; set; }
    }
}