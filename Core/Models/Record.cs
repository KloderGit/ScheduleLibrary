using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Record : Item, IPeriod
    {
        public Guid Visitor { get; set; }

        public string Rate { get; set; }

        public bool isExcelent { get; set; }

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