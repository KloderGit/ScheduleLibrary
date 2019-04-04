using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Composition : Store
    {

        public Unit Unit { get; set; }
        public Guid UnitGuid { get; set; }

        public Topic Topic { get; set; }
        public Guid TopicGuid { get; set; }

        public int Order { get; set; }

        public DateTimeOffset During { get; set; }

        public Teacher Teacher { get; set; }

    }
}