using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class TestReport : Domain.Report, ILink
    {
        /// <summary>
        /// Вид аттестации (Пятибальная\Зачет\Тест)
        /// </summary>
        public Certification Certification { get; set; }

        /// <summary>
        /// Ограничение мест
        /// </summary>
        public int Limit { get; set; }

        /// <summary>
        /// Ссылка на запись в 1С
        /// </summary>
        public Guid? Link { get; set; }
    }
}