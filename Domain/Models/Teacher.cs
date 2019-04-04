using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Teacher : Item, ILink
    {
        /// <summary>
        /// Guid связанной записи в 1С
        /// </summary>
        public Guid? Link { get; set; }
    }
}