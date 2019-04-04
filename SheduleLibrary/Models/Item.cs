using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SheduleLibrary
{
    [NotMapped]
    public abstract class Item : Store, IEntity
    {
        public bool Active { get; set; }

        /// <summary>
        /// Коммент для записи
        /// </summary>
        public String Comment
        { get; set;}

        /// <summary>
        /// Список Тегов для записи
        /// </summary>
        //public List<Tag> Tags { get; set; } = new List<Tag>();

        /// <summary>
        /// Название
        /// </summary>
        public string Title
        { get; set;}
    }
}