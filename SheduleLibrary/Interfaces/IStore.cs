using System;

namespace SheduleLibrary
{
    public interface IStore : IGuid
    {

        /// <summary>
        /// Дата создания
        /// </summary>
        System.DateTime Created { get; set; }

        /// <summary>
        /// Дата изменений
        /// </summary>
        System.DateTime Modify { get; set; }

        /// <summary>
        /// Черновик
        /// </summary>
        bool Draft { get; set; }
    }
}