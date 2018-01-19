using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Commons
{
    public class BaseEntity
    {
        public string Id { get; set; }
        public string CreationUser { get; set; }
        public DateTime CreationTime { get; set; }
        public string LastUpdateUser { get; set; }
        public DateTime LastUpdateTime { get; set; }
        public string RequestFrom { get; set; }
    }
}
