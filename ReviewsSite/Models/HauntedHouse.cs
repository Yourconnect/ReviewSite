using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Models
{
    public class HauntedHouse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public string Location { get; set; }
        public double Price { get; set; }
        //Do we need to add an id for reviews?
        public virtual List<Review> Reviews { get; set; }




    }


}
