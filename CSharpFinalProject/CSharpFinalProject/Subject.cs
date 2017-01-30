namespace CSharpFinalProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Subject
    {
        public int SubjectId { get; set; }

        public string SubjectName { get; set; }

        public int? Student_StudentId { get; set; }

        public virtual Student Student { get; set; }
    }
}
