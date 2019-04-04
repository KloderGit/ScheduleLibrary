using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Topic : Item, ILink
    {
        // <summary>
        // Вид аттестации(Экзамен\Зачет\Тест)
        // </summary>
        public Domain.Certification Certification { get; set; }
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