using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IRB.ModelsData
{
    public class PhotoGalleryDataModel
    {
        public int Id { get; set; }

        public int EventId { get; set; }

        public string Name { get; set; }

        public string Url { get; set; }

        public EventDataModel Event { get; set; }
    }
}
