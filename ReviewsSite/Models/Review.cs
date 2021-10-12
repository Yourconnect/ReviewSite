using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int HauntedHouseId { get; set; }
        public virtual HauntedHouse HauntedHouse { get; set; }
        public int Scareablity { get; set;}
        public bool Recommend { get; set; }
        public bool WouldReturn { get; set; }
        public int StarRating { get; set; }
        public string Comment { get; set; }
        public string Author { get; set; }
        public Review()
        {

        }
        public Review(string Author, string Comment, int StarRating)
        {
            this.Author = Author;
            this.Comment = Comment;
            this.StarRating = StarRating;
        }
    }

}
