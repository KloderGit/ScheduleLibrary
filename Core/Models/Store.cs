using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public abstract class Store : IStore
    {
        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime Created
        { get; set;}

        /// <summary>
        /// Черновик
        /// </summary>
        public bool Draft
        { get; set;}

        /// <summary>
        /// Идентификатор в БД
        /// </summary>
        public Guid Guid
        { get; set;}

        /// <summary>
        /// Дата изменений
        /// </summary>
        public DateTime Modify
        { get; set;}
    }
}