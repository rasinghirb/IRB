using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IRB.ModelsData
{
    public class PresentStatusDataModel
    {
        public int Id { get; set; }

        public int PISNo { get; set; }
        public string Presentstatus { get; set; }
        public int PresentStatusflag { get; set; }
        public string AtPresent { get; set; }
      
    }
}
