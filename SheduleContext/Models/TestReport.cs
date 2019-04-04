using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class TestReport : Domain.Report
    {
        public Certification Certification
        {
            get => default(Certification);
            set
            {
            }
        }

        public int Limit
        {
            get => default(int);
            set
            {
            }
        }
    }
}