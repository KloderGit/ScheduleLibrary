using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public interface IReport : IPeriod
    {
        Record Records { get; set; }
    }
}