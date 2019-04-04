using System;

namespace SheduleLibrary
{
    public class CertificationGrade : IGuid
    {
        public Guid Guid { get; set; }

        public Certification Ceritifacion { get; set; }

        public Guid CertificationGuid { get; set; }

        public Grade Grade { get; set; }

        public Guid GradeGuid { get; set; }
    }
}