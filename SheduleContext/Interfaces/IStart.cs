using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public interface IStart : IEntity
    {
        DateTime Start { get; set; }
    }
}