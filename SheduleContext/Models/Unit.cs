using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Unit : IGuidLink, IEntity
    {

        public string Segment
        {
            get => default(string);
            set
            {
            }
        }

        public string VisitingOption
        {
            get => default(string);
            set
            {
            }
        }

        public string Type
        {
            get => default(string);
            set
            {
            }
        }

        public IDictionary<int, Topic> Topics
        {
            get => default(IDictionary<int, Topic>);
            set
            {
            }
        }

        public int Price
        {
            get => default(int);
            set
            {
            }
        }
    }
}