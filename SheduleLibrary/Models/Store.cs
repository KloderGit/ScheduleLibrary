using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SheduleLibrary
{
    public abstract class Store : IStore
    {
        /// <summary>
        /// Идентификатор в БД
        /// </summary>
        public Guid Guid
        { get; set; }

        /// <summary>
        /// Черновик
        /// </summary>
        public bool Draft
        { get; set;}

        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime Created
        { get; set; }

        /// <summary>
        /// Дата изменений
        /// </summary>
        public DateTime Modify
        { get; set;}
    }
}