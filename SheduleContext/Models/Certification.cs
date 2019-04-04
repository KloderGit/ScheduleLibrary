using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Certification : IGuidLink, IEntity
    {
        public IEnumerable<Grade> Grades
        {
            get => default(IEnumerable<Grade>);
            set
            {
            }
        }

    }
}