using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Event1 : Event, ILink
    {

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

        public Guid Link { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}