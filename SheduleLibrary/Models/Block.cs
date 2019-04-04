using System;
using System.Collections.Generic;
using System.Text;

namespace SheduleLibrary
{
    public class Block : Event, ILink, IBuildOn<Unit>
    {
        /// <summary>
        /// Список событий 
        /// </summary>
        public List<Plan> Events { get; set; }

        /// <summary>
        /// Ссылка на родителя. Если Блок обучения создан из учебного плана готовых программ
        /// </summary>
        public Unit Master { get; set; }
        public Guid? MasterGuid { get; set; }

        /// <summary>
        /// Ссылка на запись в 1С
        /// </summary>
        public Guid? Link { get; set; }
    }
}