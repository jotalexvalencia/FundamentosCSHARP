using _11_Linq.Models;

namespace _11_Linq.Models
{
    public class Post : IRequestable
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string body { get; set; }
    }
}
