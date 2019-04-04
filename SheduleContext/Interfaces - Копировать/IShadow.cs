using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public interface IEntity : IModify
    {
        Guid Guid { get; set; }
        String Title { get; set; }
    }
}