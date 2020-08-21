using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IRB.Models
{
    public class ProfilePicModel
    {
        [Key]
        public int Id { get; set; }

        public int PISNo { get; set; }
        public string Name { get; set; }

        public string Url { get; set; }
    }
}
