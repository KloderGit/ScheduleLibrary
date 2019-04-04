using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public abstract class Report : IGuidLink, IPeriod
    {

        public Unit Unit
        {
            get => default(int);
            set
            {
            }
        }

        public Topic Topic
        {
            get => default(int);
            set
            {
            }
        }

        public string Subgroup
        {
            get => default(int);
            set
            {
            }
        }

        public Record Records
        {
            get => default(int);
            set
            {
            }
        }

        public string Group
        {
            get => default(int);
            set
            {
            }
        }
    }
}