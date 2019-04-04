using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Certification : Item, ILink
    {
        /// <summary>
        /// Система оценки (Пятизальная\Зачет)
        /// </summary>
        public IEnumerable<Grade> Grades { get; set; }

        /// <summary>
        /// Guid связанной записи в 1С
        /// </summary>
        public Guid? Link { get; set; }
    }
}