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
            var movie = MvcApplication.Movies.First(x => x.Id == id);
            movie.VoteCount++;

            // Call the broadcastMessage method to update clients.
            Clients.All.broadcastMessage(id, movie.VoteCount);
        }
    }
}