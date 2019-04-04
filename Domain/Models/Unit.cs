using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain
{
    public class Unit : Item, ILink
    {

        /// <summary>
        /// Стоимость мероприятия со всеми дисциплинами
        /// </summary>
        public int Price { get; set; }

        /// <summary>
        /// Учебный центр \ Школа управления
        /// </summary>
        public string Segment { get; set; }

        /// <summary>
        /// Тип мероприятия - Программа обучения \ Семинар \ Стажировка
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Форма обучения - Очное \ Открытое \ Дистанционное и пр. посещение
        /// </summary>
        public string VisitOption { get; set; }

        /// <summary>
        /// Учебный план - Дисциплины
        /// </summary>
        public IEnumerable<Composition> Composition { get; set; }

        /// <summary>
        /// Guid связанной записи в 1С
        /// </summary>
        public Guid? Link { get; set; }
    }
}