using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IRB.ModelsData
{
    public class MasterRollDataModel
    {

        [Key]
        public int Id { get; set; }

        public int PISNo { get; set; }

        public string Name { get; set; }

        public int Rank { get; set; }

        public int Coy { get; set; }

        public string NextOfKin { get; set; }


        public DateTime DoB { get; set; }

        public string Address1 { get; set; }

        public int AddressPatelat { get; set; }

        public int AddressState { get; set; }

        public int BloodGroup { get; set; }

        public DateTime Doj { get; set; }

        public string MobileNo { get; set; }

        public string EmergencyContactNo { get; set; }

        public int MaritialStatus { get; set; }

        public int Education { get; set; }

        public int PlaceofPosting { get; set; }

        public string EmailAdd { get; set; }

        public int RelationwithNextofKin { get; set; }

        public int Category { get; set; }

        public int Religion { get; set; }

        public int Status { get; set; }

        public string ImageUrl { get; set; }

        public DateTime Wef { get; set; }

        public string AdharNo { get; set; }

        public string PanNo { get; set; }

        public string FatherName { get; set; }

        public ICollection<ProfilePicDataModel> profilePicDataModel { get; set; }
    }
}
