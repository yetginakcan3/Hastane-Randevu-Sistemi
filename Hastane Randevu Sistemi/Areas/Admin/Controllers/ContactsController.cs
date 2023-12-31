﻿using Hospital.Models;
using Hospital.Services;
using Hospital.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Hastane_Randevu_Sistemi.Areas.Admin.Controllers
{
    [Area("admin")]
    public class ContactController : Controller
    {
        private IContactService _contact;
        private IHospitalInfo _hospitalInfo;

        public ContactController(IContactService contact,IHospitalInfo hospitalInfo)
        {
            _contact = contact;
            _hospitalInfo = hospitalInfo;
        }
       
        public IActionResult Index(int pageNumber=1,int pageSize=10)
        {
            return View(_contact.GetAll(pageNumber,pageSize));
        }

        [HttpGet]


        public IActionResult Edit(int id) 
        {
            ViewBag.hospital = new SelectList(_hospitalInfo.GetAll(), "Id", "Name");
            var viewModel = _contact.GetContactById(id);
            return View(viewModel);
        }
        [HttpPost]
        public IActionResult Edit(ApplicationUserViewModel vm) 
        {
            _contact.UpdateContact(vm);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Create() 
        {
            ViewBag.hospital = new SelectList(_hospitalInfo.GetAll(), "Id", "Name");
            return View();
        }



        [HttpPost]

        public IActionResult Create(ApplicationUserViewModel vm) 
        {
        _contact.InsertContact(vm);
            return RedirectToAction("Index");
        }

        public IActionResult Delete (int id)
        {
            _contact.DeleteContact(id);
            return RedirectToAction("Index");
        }
    }
}
