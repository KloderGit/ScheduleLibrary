using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public interface IGuid
    {
        /// <summary>
        /// Идентификатор в БД
        /// </summary>
        Guid Guid { get; set; }
    }
}