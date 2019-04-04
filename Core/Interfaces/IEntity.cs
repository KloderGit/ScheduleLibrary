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
        String Comment { get; set; }
        Domain.EntityTag Tags { get; set; }
    }
}