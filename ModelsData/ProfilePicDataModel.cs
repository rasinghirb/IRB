using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IRB.ModelsData
{
    public class ProfilePicDataModel
    {

        public int Id { get; set; }

        public int PISNo { get; set; }

        public string Name { get; set; }

        public string Url { get; set; }

        public MasterRollDataModel masterRollDataModel { get; set; }
    }
}
