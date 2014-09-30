using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VoteMovie
{
    public class VoteHub : Hub
    {
        public void Vote(int id)
        {
            var movie = Repository.Movies.First(x => x.Id == id);
            movie.VoteCount++;

            var positions = Repository.Movies
                            .OrderByDescending(x => x.VoteCount)
                            .Select(x => new MoviePosition { Id = x.Id, VoteCount = x.VoteCount });

            // Call the broadcastMessage method to update clients.
            Clients.All.broadcastMessage(positions);
        }

        public class MoviePosition
        {
            public int Id { get; set; }
            public int VoteCount { get; set; }
        }
    }

    
}