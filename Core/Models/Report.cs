using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public abstract class Report : Item, IReport
    {
        /// <summary>
        /// Для программы
        /// </summary>
        public Unit Unit
        { get; set;}

        /// <summary>
        /// Для дисциплины
        /// </summary>
        public Topic Topic
        { get; set;}

        /// <summary>
        /// Подгруппа обучения (Термин 1С)
        /// </summary>
        public string Subgroup
        { get; set;}

        /// <summary>
        /// Block \ Группа обучения (Термин 1С)
        /// </summary>
        public Block Group
        { get; set;}

        /// <summary>
        /// Список записей ведомости
        /// </summary>
        public Record Records
        { get; set;}

        /// <summary>
        /// Дата или время окончания
        /// </summary>
        public DateTime Finish
        { get; set;}

        /// <summary>
        /// Дата или время старта
        /// </summary>
        public DateTime Start
        { get; set;}
    }
}