using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Grade : IEntity, IGuidLink
    {
        public System.Enum Max
        {
            get => default(Enum);
            set
            {
            }
        }

        public System.Enum Min
        {
            get => default(Enum);
            set
            {
            }
        }
    }
}