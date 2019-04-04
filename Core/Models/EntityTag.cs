using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class EntityTag : IGuid
    {

        public List<Domain.TagReferences> References { get; set; }

        public Guid Guid { get; set; }
    }
}