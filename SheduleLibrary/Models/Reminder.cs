using System;
using System.Collections.Generic;
using System.Text;

namespace SheduleLibrary
{
    public class Reminder : Item, IPeriod
    {
        /// <summary>
        /// Следующее напоминание через
        /// </summary>
        public DateTimeOffset Repeat { get; set; }

        /// <summary>
        /// Дата или время окончания
        /// </summary>
        public DateTime Finish { get; set; }

        /// <summary>
        /// Дата или время старта
        /// </summary>
        public DateTime Start { get; set; }
    }
}