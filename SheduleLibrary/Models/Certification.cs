using System;
using System.Collections.Generic;
using System.Text;

namespace SheduleLibrary
{
    public class Certification : Item, ILink
    {
        /// <summary>
        /// Система оценки (Пятизальная\Зачет)
        /// </summary>
        public List<CertificationGrade> Grades { get; set; }

        public List<Composition> Compositions { get; set; }

        public List<Plan> Plans { get; set; }

        /// <summary>
        /// Ссылка на запись в 1С
        /// </summary>
        public Guid? Link { get; set; }
    }
}