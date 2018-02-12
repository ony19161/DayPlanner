using App.Commons;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Model
{
    public class TaskReminder : BaseEntity
    {
        [Required]
        public DateTime Date { get; set; }

        [Required]
        public string Time { get; set; }

        public string TaskId { get; set; }

        [Required]
        public string RemindBy { get; set; }

        [ForeignKey("TaskId")]
        public virtual Task Task { get; set; }
    }
}
