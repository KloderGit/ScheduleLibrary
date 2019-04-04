using System;
using System.Collections.Generic;
using System.Text;

namespace SheduleLibrary
{
    public interface IReport
    {
        Record Records { get; set; }
    }
}