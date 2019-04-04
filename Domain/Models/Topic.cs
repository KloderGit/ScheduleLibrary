using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Topic : Item, ILink
    {
        /// <summary>
        /// Вид аттестации (Пятибальная\Зачет\Тест)
        /// </summary>
        public Certification Certification { get; set; }

        /// <summary>
        /// Место проведения
        /// </summary>
        public int Place { get; set; }

        /// <summary>
        /// Guid связанной записи в 1С
        /// </summary>
        public Guid? Link { get; set; }

        /// <summary>
        /// Учебный план - Программы
        /// </summary>
        public IEnumerable<Composition> Composition { get; set; }
    }
}