using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Event : Item, IPeriod, IBuildOn<object>
    {

        public IEnumerable<Event1> Events
        {
            get => default(IEnumerable<Event1>);
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

        public int Start
        {
            get => default(int);
            set
            {
            }
        }

        public int Finish
        {
            get => default(int);
            set
            {
            }
        }

        public Place Place
        {
            get => default(Place);
            set
            {
            }
        }

        public EventType Type { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}