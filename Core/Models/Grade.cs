using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Grade : Item, ILink
    {
        /// <summary>
        /// Максимальный балл
        /// </summary>
        public System.Enum Max { get; set; }
        /// <summary>
        /// Минимальный балл
        /// </summary>
        public System.Enum Min { get; set; }

        /// <summary>
        /// Ссылка на запись в 1С
        /// </summary>
        public Guid? Link { get; set; }

        public Certification Certification { get; set; }
    }
}