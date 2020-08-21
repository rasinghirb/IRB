using IRB.Data.Ennum;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IRB.Models
{
    public class MasterRollModel
    {

       
        [Required]
        [Display(Name = "PIS No")]
        public int PISNo { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Rank")]
        public rank Rank { get; set; }
        [Required]
        [Display(Name = "Coy")]
        public coy Coy { get; set; }
        [Required]
        [Display(Name = "Next of Kin")]
        public string NextOfKin { get; set; }

        [Required]
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime DoB { get; set; }
        [Required]
        [Display(Name = "Address")]
        public string Address1 { get; set; }
        [Required]
        [Display(Name = "Patelat")]
        public patelat AddressPatelat { get; set; }
        [Required]
        [Display(Name = "State")]
        public state AddressState { get; set; }
        [Required]
        [Display(Name = "BloodGroup")]
        public bloodGroup BloodGroup { get; set; }
        [Required]
        [Display(Name = "Date of Joining")]
        [DataType(DataType.Date)]
        public DateTime Doj { get; set; }
        [Required]
        [Display(Name = "Mobile No")]
        public string MobileNo { get; set; }
        [Required]
        [Display(Name = "Emergency No")]
        public string EmergencyContactNo { get; set; }
        [Required]
        [Display(Name = "Martial Status")]
        public martialStatus MaritialStatus { get; set; }
        [Required]
        [Display(Name = "Education")]
        public education Education { get; set; }
        [Required]
        [Display(Name = "Place of Posting")]
        public placeOfPosting PlaceofPosting { get; set; }
        [Required]
        [Display(Name = "Email")]
        public string EmailAdd { get; set; }
        [Required]
        [Display(Name = "Relation with Next of Kin")]
        public relationShip RelationwithNextofKin { get; set; }
        [Required]
        [Display(Name = "Category")]
        public category Category { get; set; }
        [Required]
        [Display(Name = "Religion")]
        public religion Religion { get; set; }
        [Required]
        [Display(Name = "Status")]
        public int Status { get; set; }
        
        public string ImageUrl { get; set; }
        [Required]
        [Display(Name = "Upload Profile Photo")]
        public IFormFile ProfilePic { get; set; }

        [Required]
        [Display(Name = "With Effect from")]
        [DataType(DataType.Date)]
        public DateTime Wef { get; set; }
        [Required]
        [Display(Name = "Adhar No")]
        public string AdharNo { get; set; }
        [Required]
        [Display(Name = "PAN No")]
        public string PanNo { get; set; }
        [Required]
        [Display(Name = "Father's Name")]
        public string FatherName { get; set; }

        public List<ProfilePicModel> Gallery { get; set; }

    }
}
