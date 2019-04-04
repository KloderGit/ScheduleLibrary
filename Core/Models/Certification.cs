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
        public List<Domain.Grade> Grades { get; set; }

        /// <summary>
        /// Ссылка на запись в 1С
        /// </summary>
        public Guid? Link { get; set; }

        public List<Domain.Topic> Topic { get; set; }
    }
}