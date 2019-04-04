using System;
using System.Collections.Generic;
using System.Text;

namespace SheduleLibrary
{
    public interface IEntity : IStore
    {

        /// <summary>
        /// Название
        /// </summary>
        String Title { get; set; }
        String Comment { get; set; }
        bool Active { get; set; }
    }
}