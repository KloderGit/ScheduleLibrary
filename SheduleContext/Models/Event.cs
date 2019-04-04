using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Event : IPeriod, IParent
    {

        public Place Place
        {
            get => default(Place);
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

        public IEnumerable<Report> Reports
        {
            get => default(IEnumerable<Report>);
            set
            {
            }
        }

        public bool Reminder
        {
            get => default(bool);
            set
            {
            }
        }

        public EventType Type
        {
            get => default(string);
            set
            {
            }
        }
    }
}