using BlueMusic.Domain.Primatives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BlueMusic.Domain.Entities
{
    public class Song : Entity
    {
        public Song(Guid id, string title, Guid artistId, Guid? albumId)
            : base(id)
        {
            Title = title;
            ArtistId = artistId;
            AlbumId = albumId;
        }

        public string Title { get; set; } = null!;

        public Guid ArtistId { get; set; }

        public Guid? AlbumId { get; set; }
    }
}
