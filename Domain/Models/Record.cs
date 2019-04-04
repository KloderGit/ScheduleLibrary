using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Record : Item, IPeriod
    {
        public Guid Visitor { get; set; }

        public Grade Rate { get; set; }

        public bool isExcelent { get; set; }

        public DateTime Finish { get; set; }
        public DateTime Start { get; set; }
    }
}