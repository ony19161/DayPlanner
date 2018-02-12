using App.Commons;
using System.ComponentModel.DataAnnotations;

namespace App.Model
{
    public class TaskType : BaseEntity
    {
        [Required]
        public string Type { get; set; }

    }
}
