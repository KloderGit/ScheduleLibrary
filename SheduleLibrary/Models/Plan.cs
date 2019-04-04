using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SheduleLibrary
{
    public class Plan : IGuid
    {
        public Block Block { get; set; }

        public Guid BlockGuid { get; set; }

        public Part Part { get; set; }

        public Guid PartGuid { get; set; }

        public Guid Guid { get; set; }

        public SheduleLibrary.Certification Certification { get; set; }

        /// <summary>
        /// Длительность
        /// </summary>
        public TimeSpan? During { get; set; }

        /// <summary>
        /// Список ведомостей (Аттестаций\Посещений)
        /// </summary>
        public Record Record { get; set; }
        public Guid? RecordGuid { get; set; }
    }
}