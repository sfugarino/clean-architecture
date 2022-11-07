using BlueMusic.Domain.Primatives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueMusic.Domain.Entities
{
    public class Artist : Entity
    {
        public Artist(Guid id, string name)
            : base(id)
        {
            Name = name;
        }

        public string Name { get; set; } = null!;
    }
}
