using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public abstract class Store : IStore
    {
        public DateTime Created { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool Draft { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public DateTime Modify { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Guid Guid { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}