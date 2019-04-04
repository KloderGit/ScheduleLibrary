using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public interface IPeriod : IStart
    {
        System.DateTime Finish { get; set; }
    }
}