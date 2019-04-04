using System;
using System.Collections.Generic;
using System.Text;

namespace SheduleLibrary
{
    public class Report : Item, IReport, ILink
    {
        /// <summary>
        /// Для программы
        /// </summary>
        public Unit Unit
        { get; set; }

        /// <summary>
        /// Для дисциплины
        /// </summary>
        public Topic Topic
        { get; set; }

        /// <summary>
        /// Подгруппа обучения (Термин 1С)
        /// </summary>
        public string Subgroup
        { get; set; }

        /// <summary>
        /// Block \ Группа обучения (Термин 1С)
        /// </summary>
        public Block Group
        { get; set; }

        /// <summary>
        /// Ссылка на запись в 1С
        /// </summary>
        public Guid? Link { get; set; }

        /// <summary>
        /// Ограничение мест
        /// </summary>
        public int Limit { get; set; }

        public bool isVisited { get; set; }

        public string Rate
        {
            get => default(int);
            set
            {
            }
        }
    }
}