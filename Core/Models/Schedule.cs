using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Block : Event, ILink, IBuildOn<Unit>
    {
        /// <summary>
        /// Список событий 
        /// </summary>
        public List<Sheme> Events { get; set; }

        /// <summary>
        /// Ссылка на родителя. Если Блок обучения создан из учебного плана готовых программ
        /// </summary>
        public Unit Master { get; set; }

        /// <summary>
        /// Ссылка на запись в 1С
        /// </summary>
        public Guid? Link { get; set; }
    }
}