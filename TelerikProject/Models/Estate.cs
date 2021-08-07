using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TelerikProject.Models
{
    public class Estate
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public float Cost { get; set; }
        public String Description { get; set; }
    }
}
