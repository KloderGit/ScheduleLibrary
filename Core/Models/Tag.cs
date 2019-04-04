using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Tag : Store
    {
        public String Title { get; set; }

        public List<Domain.TagReferences> References { get; set; } 
    }
}