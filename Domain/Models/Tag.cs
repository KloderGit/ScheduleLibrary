using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain
{
    public class Tag : IStore
    {
        [Key]
        public Guid Guid { get; set; }

        public int Key { get; set; }

        public string Value { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// Дата изменений
        /// </summary>
        public DateTime Modify { get; set; }

        /// <summary>
        /// Черновик
        /// </summary>
        public bool Draft { get; set; }

        public IEnumerable<Composition> Units { get; set; }
    }
}