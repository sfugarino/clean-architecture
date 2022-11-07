﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueMusic.Domain.Primatives
{
    public abstract class Entity
    {
        protected Entity(Guid id) => Id = id;

        protected Entity() { }

        public Guid Id { get; protected set; }
    }
}
