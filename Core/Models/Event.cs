using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
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
        public EventType Type
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