using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Record : IPeriod
    {

        public Guid Visitor
        {
            get => default(int);
            set
            {
            }
        }

        public Grade Rate
        {
            get => default(int);
            set
            {
            }
        }

        public string Comment
        {
            get => default(int);
            set
            {
            }
        }

        public bool isExcelent
        {
            get => default(int);
            set
            {
            }
        }
    }
}