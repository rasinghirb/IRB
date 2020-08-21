using IRB.ModelsData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IRB.Repository
{
    interface IMasterRoll
    {
        Task<int> AddNewAsync(MasterRollDataModel mstrRoll);
        Task EditAsync(MasterRollDataModel mstrRoll);
        MasterRollDataModel GetSingleParticular(int id);
        Task Delete(int pisNo);
        List<MasterRollDataModel> GetAllAsync();
        bool VerifyPISNo(int pisNo);
        List<MasterRollDataModel> SearchName(string search);
        List<MasterRollDataModel> GetByUserIdAsync(int pisNo);
        
    }
}
