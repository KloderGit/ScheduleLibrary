using System;
using System.Collections.Generic;
using System.Text;

namespace SheduleLibrary
{
    public class Record : Item, IPeriod
    {
        public Visitor Visitor { get; set; }

        /// <summary>
        /// Дата или время окончания
        /// </summary>
        public DateTime Finish { get; set; }

        /// <summary>
        /// Дата или время старта
        /// </summary>
        public DateTime Start { get; set; }

        public Report TestReport { get; set; }

        /// <summary>
        /// Список записей ведомости
        /// </summary>
        public SheduleLibrary.Report VisitReport
        { get; set; }
    }
}