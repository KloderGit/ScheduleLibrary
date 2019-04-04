using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public interface IEvent : IEntity, IPeriod
    {
    }
}