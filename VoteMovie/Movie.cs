using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VoteMovie
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int VoteCount { get; set; }
    }
}