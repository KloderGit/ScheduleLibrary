using System;
using System.Collections.Generic;
using System.Text;

namespace SheduleLibrary
{
    public interface IGuid
    {
        /// <summary>
        /// Идентификатор в БД
        /// </summary>
        Guid Guid { get; set; }
    }
}