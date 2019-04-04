using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Grade : Store, ILink
    {
        public System.Enum Max { get; set; }
        public System.Enum Min { get; set; }

        /// <summary>
        /// Guid связанной записи в 1С
        /// </summary>
        public Guid? Link { get; set; }
    }
}