using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IRB.ModelsData
{
    public class EventDataModel
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public ICollection<PhotoGalleryDataModel> photoGalleryDataModel { get; set; }
    }
}
