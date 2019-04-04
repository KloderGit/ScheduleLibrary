using System;
using System.Collections.Generic;
using System.Text;

namespace SheduleLibrary
{
    public class Event : Item, IEvent
    {
        /// <summary>
        /// Цена мероприятия
        /// </summary>
        public int Price
        { get; set;}

        /// <summary>
        /// Место проведения
        /// </summary>
        public Place Place
        { get; set;}

        /// <summary>
        /// Тип мероприятия (Лекция\Вебинар\Аттестация)
        /// </summary>
        //public EventTypes? Type { get; set;}

        /// <summary>
        /// Дата или время окончания
        /// </summary>
        public DateTime Finish
        { get; set;}

        /// <summary>
        /// Дата или время старта
        /// </summary>
        public DateTime Start
        { get; set; }

        /// <summary>
        /// Напоминание
        /// </summary>
        public Reminder Reminder { get; set; }

        /// <summary>
        /// Действия на События с одинаковым Sibling влияют на всех
        /// </summary>
        public Guid? Siblings { get; set; }
    }
}