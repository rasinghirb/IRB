using IRB.Models;
using IRB.ModelsData;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IRB.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            //{
            //    Database.EnsureCreated();
            //}
        }
        //public DbSet<MasterRollDataModel> MasterRoll { get; set; }
        public DbSet<ProfilePicDataModel> ProfilePhoto { get; set; }
        public DbSet<PhotoGalleryDataModel> PhotoGallery { get; set; }
        public DbSet<EventDataModel> Event { get; set; }
        public DbSet<MasterRollDataModel> tbleMasterRoll { get; set; }
        public DbSet<PresentStatusDataModel> tblePresentStatus { get; set; }
        public DbSet<AdharDataModel> tbleadharNo { get; set; }
        public DbSet<UnitTenureDataModel> tbleIRBnPersonalunitDurati { get; set; }
    }

}
