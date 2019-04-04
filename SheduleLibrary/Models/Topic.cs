using System;
using System.Collections.Generic;
using System.Text;

namespace SheduleLibrary
{
    public class Topic : Item, ILink
    {
        //public Guid CertificationGuid { get; set; }

        /// <summary>
        /// Учебный план - Программы
        /// </summary>
        public List<Composition> Composition { get; set; }

        /// <summary>
        /// Ссылка на запись в 1С
        /// </summary>
        public Guid? Link { get; set; }
    }
}