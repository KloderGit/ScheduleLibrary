using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public interface ILink
    {
        /// <summary>
        /// Ссылка на запись в 1С
        /// </summary>
        System.Guid? Link { get; set; }
    }
}