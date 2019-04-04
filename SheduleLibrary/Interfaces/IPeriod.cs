using System;
using System.Collections.Generic;
using System.Text;

namespace SheduleLibrary
{
    public interface IPeriod
    {
        /// <summary>
        /// Дата или время окончания
        /// </summary>
        System.DateTime Finish { get; set; }

        /// <summary>
        /// Дата или время старта
        /// </summary>
        DateTime Start { get; set; }
    }
}