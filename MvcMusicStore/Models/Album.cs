using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMusicStore.Models
{
    public class Album
    {
        public virtual int AlbumID {get;set; }
        public virtual int GenreID { get; set; }
        public virtual int ArtistID { get; set; }
        public virtual string Title { get; set; }
        public virtual decimal Price { get; set; }
        public virtual string AlbumArtUrl { get; set; }
        public virtual Genre Genre { get; set; }
        public virtual Artist Artist { get; set; }

    }
}