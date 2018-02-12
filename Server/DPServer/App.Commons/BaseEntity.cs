using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Commons
{
    public abstract class BaseEntity
    {
        protected BaseEntity()
        {

        }

        [Key]
        public string Id { get; set; }
        [Required]
        public string CreationUser { get; set; }
        [Required]
        public DateTime CreationTime { get; set; }
        [Required]
        public string LastUpdateUser { get; set; }
        [Required]
        public DateTime LastUpdateTime { get; set; }
        [Required]
        public string CreatedFrom { get; set; }
        [Required]
        public string UpdatedFrom { get; set; }
    }
}
