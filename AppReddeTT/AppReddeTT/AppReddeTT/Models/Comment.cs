using System;

namespace AppReddeTT.Models
{
    public class Comment
    {
        public string Author { get; set; }
        public string Content { get; set; }
        public DateTime DateCreated { get; set; }
    }
}