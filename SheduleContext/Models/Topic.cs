using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Topic : IGuidLink, IEntity
    {
        public Certification Certification
        {
            get => default(Certification);
            set
            {
            }
        }

        public int Price
        {
            get => default(int);
            set
            {
            }
        }

        public int Place
        {
            get => default(int);
            set
            {
            }
        }
    }
}