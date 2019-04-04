using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Schedule : Event, ILink
    {

        public Guid Link { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}