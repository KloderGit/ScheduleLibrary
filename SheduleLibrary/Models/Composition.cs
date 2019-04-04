using System;
using System.Collections.Generic;
using System.Text;

namespace SheduleLibrary
{
    public class Composition : IGuid
    {

        /// <summary>
        /// Блок обучения
        /// </summary>
        public Unit Unit { get; set; }
        public Guid UnitGuid { get; set; }
        /// <summary>
        /// Дисциплина
        /// </summary>
        public Topic Topic { get; set; }
        public Guid TopicGuid { get; set; }

        /// <summary>
        /// Позиция в учебном плане
        /// </summary>
        public int Order { get; set; }

        /// <summary>
        /// Длительность
        /// </summary>
        public TimeSpan? During { get; set; }

        /// <summary>
        /// Преподаватель
        /// </summary>
        public Teacher Teacher { get; set; }
        public Guid? TeacherGuid { get; set; }

        public SheduleLibrary.Certification Certification { get; set; }
        public Guid? CertificationGuid { get; set; }

        public Guid Guid { get; set; }
    }
}