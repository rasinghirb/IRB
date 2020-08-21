using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IRB.Models
{
    public class EventModel
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Display(Name = "Event Name")]
        public string Name { get; set; }

        [Display(Name = "Load images ")]
        [Required]
        public IFormFileCollection EventPhotoFIle { get; set; }
        public List<PhotoGalleryModel> Gallery { get; set; }

    }
}
