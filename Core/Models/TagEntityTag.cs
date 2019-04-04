using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class TagReferences : IGuid
    {
        public Tag Tag { get; set; }

        public Guid TagGuid { get; set; }

        public EntityTag EntityTag { get; set; }

        public Guid EntityTagGuid { get; set; }

        public Guid Guid { get; set; }
    }
}