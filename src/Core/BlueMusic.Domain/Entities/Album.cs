using BlueMusic.Domain.Primatives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueMusic.Domain.Entities
{
    public class Album : Entity
    {
        public Album(Guid id, string title, Guid artistId)
            : base(id)
        {
            Title = title;
            ArtistId = artistId;
        }

        public string Title { get; set; } = null!;

        public Guid ArtistId { get; set; } 
    }
}
