using System;

namespace DIO.Series.Shared
{
    public abstract class Entity 
    {
        public Entity()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; protected set; }

    }

}
