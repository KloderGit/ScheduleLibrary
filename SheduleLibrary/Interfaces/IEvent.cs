using System;
using System.Collections.Generic;
using System.Text;

namespace SheduleLibrary
{
    public interface IEvent : IEntity, IPeriod
    {
    }
}