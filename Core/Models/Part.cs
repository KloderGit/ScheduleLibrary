using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Part : Event, ILink, IBuildOn<Topic>
    {
        /// <summary>
        /// Список ведомостей (Аттестаций\Посещений)
        /// </summary>
        public IEnumerable<Report> Reports { get; set; }

        /// <summary>
        /// Напоминание
        /// </summary>
        public Reminder Reminder { get; set; }

        /// <summary>
        /// Действия на События с одинаковым Sibling влияют на всех
        /// </summary>
        public Guid? Siblings { get; set; }

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
        public List<Sheme> Blocks { get; set; }
    }
}