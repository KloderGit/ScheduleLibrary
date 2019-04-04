using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public interface IEntity : IStore
    {

        /// <summary>
        /// Название
        /// </summary>
        String Title { get; set; }
        IEnumerable<Tag> Tags { get; set; }
        int Comment { get; set; }
    }
}