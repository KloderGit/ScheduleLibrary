using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public interface IPeriod : IStart
    {
        /// <summary>
        /// Дата или время окончания
        /// </summary>
        System.DateTime Finish { get; set; }

        /// <summary>
        /// Дата или Время старта
        /// </summary>
        DateTime Start { get; set; }
    }
}