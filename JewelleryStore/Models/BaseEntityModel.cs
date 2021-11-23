using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JewelleryStore.Models
{
    public class BaseEntityModel 
    {
        [Key]
        public int Id { get; set; }
        public string cb { get; set; }
        public DateTime cd { get; set; }
        public string mb { get; set; }
        public DateTime md { get; set; }

        public bool Active { get; set; }
    }
}
