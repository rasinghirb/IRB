using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using IRB.Data;
using IRB.Models;
using IRB.ModelsData;
using IRB.Repository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IRB.Controllers
{
    public class MasterRollController : Controller
    {

        string connectionString = ConnectionString._DCS;
        private readonly MasterRollRepository _masterRollRepository = null;
        private readonly ApplicationDbContext _dBcontext = null;
        private readonly IWebHostEnvironment _iWebHostEnvironment = null;
        //public readonly MasterRollRepository mstrRepo ;
        [ViewData]
        public string Title { get; set; }
        public MasterRollController(ApplicationDbContext Dbcontext, MasterRollRepository masterRollRepository, IWebHostEnvironment iWebHostEnvironment)
        {
            _masterRollRepository = masterRollRepository;
            _dBcontext = Dbcontext;
            _iWebHostEnvironment = iWebHostEnvironment;
        }
        public IActionResult FindAll()
        {
            List<MasterRollModel> lstEmployee = new List<MasterRollModel>();
            lstEmployee = _masterRollRepository.FindAll().ToList();
            return View(lstEmployee);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add([Bind] MasterRollModel mster)
        {
            //try

            //{
            if (ModelState.IsValid)
            {
                var user = _dBcontext.tbleMasterRoll.Where(M=> M.PISNo==mster.PISNo).FirstOrDefault();
                if (user == null)
                {
                  if (mster.ProfilePic == null)
                   {
                        ViewBag.Message = "Please Select profile photo";
                   }
                    else
                    { 
                    string folder = "images/profile/";
                    mster.ImageUrl = UploadImage(folder, mster.ProfilePic);
                    _masterRollRepository.Add(mster);
                    return RedirectToAction("FindAll");
                    }
                }

                else
                {
                    ViewBag.Message = "Employee entry is already made";

                }
            }
                return View();
        }
        [HttpGet]
        public IActionResult Edit(int PISNo)
        {
                     
            MasterRollModel Master = _masterRollRepository.FindById(PISNo);
            if (Master == null)
            {
                return NotFound();
            }
            return View(Master);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind] MasterRollModel master)
        {
            if (id != master.PISNo)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                _masterRollRepository.Update(master);
                return RedirectToAction("FindAll");
            }
            return View(master);
        }
        [HttpGet]
        public IActionResult Details(int pisno)
        {
           
            MasterRollModel mster = _masterRollRepository.FindById(pisno);
            if (mster == null)
            {
                return NotFound();
            }
            return View();
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            //if (id == null)
            //{
            //    return NotFound();
            //}
            MasterRollModel mster = _masterRollRepository.FindById(id);
            if (mster == null)
            {
                return NotFound();
            }
            return View(mster);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _masterRollRepository.Delete(id);
            return RedirectToAction("Index");
        }
        private string UploadImage(string folderPath, IFormFile file)
        {
            //Uploading Images in database and folder

            folderPath += Guid.NewGuid().ToString() + file.FileName;
            string serverFolder = Path.Combine(_iWebHostEnvironment.WebRootPath, folderPath);
             file.CopyToAsync(new FileStream(serverFolder, FileMode.Create)); ;
            return "/" + folderPath;
        }
        //public bool VerifyName(int PISNo)
        //{
        //    return _dBcontext.tbleMasterRoll.Find(PISNo);
        //}
    }
}
