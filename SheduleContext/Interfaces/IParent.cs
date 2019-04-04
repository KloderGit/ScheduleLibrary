using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public interface IParent
    {
        T Parent { get; set; }
    }
}