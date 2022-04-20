using System.Collections.Generic;

namespace backend.Models
{
    public class Book
    {
        public long BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Rating { get; set; }
        public List<Subject> Subjects { get; set; }
        public List<Review> Reviews { get; set; }
        public List<Rating> Ratings { get; set; }
    }
}