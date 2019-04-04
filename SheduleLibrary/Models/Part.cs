using SheduleLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace SheduleLibrary
{
    public class Part : Event, ILink, IBuildOn<Topic>
    {

        /// <summary>
        /// Ссылка на запись в 1С
        /// </summary>
        public Guid? Link { get; set; }

        /// <summary>
        /// Ссылка на родителя. Если Блок обучения создан из учебного плана готовых программ
        /// </summary>
        public Topic Master { get; set; }

        /// <summary>
        /// Список событий 
        /// </summary>
        public List<Plan> Blocks { get; set; }
    }
}