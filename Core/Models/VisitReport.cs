using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class VisitReport : Report, ILink
    {
        /// <summary>
        /// Ссылка на запись в 1С
        /// </summary>
        public Guid? Link { get; set; }
    }
}