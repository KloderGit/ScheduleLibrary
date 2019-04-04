using System;
using System.Collections.Generic;
using System.Text;

namespace SheduleLibrary
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

        public List<CertificationGrade> Cerifications { get; set; }
    }
}