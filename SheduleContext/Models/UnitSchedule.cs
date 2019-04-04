using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Schedule : IPeriod, IParent, IGuidLink
    {
        public IEnumerable<Event> Events
        {
            get => default(IEnumerable<Event>);
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

        public int Title
        {
            get => default(int);
            set
            {
            }
        }
    }
}