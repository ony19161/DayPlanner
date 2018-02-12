using App.Commons;
using System.ComponentModel.DataAnnotations;

namespace App.Model
{
    public class Task : BaseEntity
    {
        [Required]
        public string TaskNote { get; set; }
        public string Type { get; set; }
        public string Priority { get; set; }
        public string State { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public bool HasReminder { get; set; }
    }
}
