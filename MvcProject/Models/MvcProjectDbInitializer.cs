using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcProject.Models
{
    public class MvcProjectDbInitializer:DropCreateDatabaseAlways<MvcProjectDB>
    {
        protected override void Seed(MvcProjectDB context)
        {
            context.Artists.Add(new Artist() { ArtistId=1,Name="Al Di Meola"});
            context.Genres.Add(new Genre() { Name="Jazz"});
            context.Albums.Add(new Album() { Artist = new Artist() { Name = "Rush" },
                Genre = new Genre() { Name = "Rock" },
                Price = 9.9m,
                Title="Cavana"
            });
            base.Seed(context);
        }
    }
}