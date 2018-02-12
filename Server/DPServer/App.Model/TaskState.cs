using App.Commons;
using System.ComponentModel.DataAnnotations;

namespace App.Model
{
    public class TaskState : BaseEntity
    {
        [Required]
        public string State { get; set; }
    }
}
