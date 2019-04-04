using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public abstract class Report : Item, ILink, IPeriod
    {

        public Unit Unit { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Topic Topic { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string Subgroup { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Record Records { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string Group { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public DateTime Finish { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime Start { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Guid Link { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}