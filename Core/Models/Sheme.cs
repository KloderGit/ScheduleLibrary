using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Sheme : IGuid
    {
        public Block Block { get; set; }

        public Guid BlockGuid { get; set; }

        public Part Part { get; set; }

        public Guid PartGuid { get; set; }

        public Guid Guid { get; set; }
    }
}