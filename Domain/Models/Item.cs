using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public abstract class Item : Store, IEntity
    {
        public IEnumerable<Tag> Tags { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int Title
        {
            get => default(int);
            set
            {
            }
        }

        public int Comment
        {
            get => default(int);
            set
            {
            }
        }
    }
}