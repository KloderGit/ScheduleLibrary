using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Visitor : Item, ILink
    {
        /// <summary>
        /// Ссылка на запись в 1С
        /// </summary>
        public Guid? Link { get; set; }
    }
}