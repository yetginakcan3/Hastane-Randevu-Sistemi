﻿using Hospital.Models;
using Hospital.Repositories.Interfaces;
using Hospital.Utilities;
using Hospital.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Services
{
    public class ContactService : IContactService
    {
        private IUnitOfWork _unitOfWork;

        public ContactService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void DeleteContact(int id)
        {
            var model = _unitOfWork.GenericRepository<ApplicationUser>().GetById(id);
            _unitOfWork.GenericRepository<ApplicationUser>().Delete(model);
            _unitOfWork.Save();
        }

        public PagedResult<ApplicationUserViewModel> GetAll(int pageNumber, int pageSize)
        {
            var vm = new ApplicationUserViewModel();
            int totalCount;
            List<ApplicationUserViewModel> vmList = new List<ApplicationUserViewModel>();
            try
            {
                int ExcludeRecords = (pageSize * pageNumber) - pageSize;
                var modelList = _unitOfWork.GenericRepository<ApplicationUser>().GetAll(includeProperties:"Hospital").
                    Skip(ExcludeRecords).Take(pageSize).ToList();


                totalCount = _unitOfWork.GenericRepository<ApplicationUser>().GetAll().ToList().Count;

                vmList = ConvertModelToViewModelList(modelList);
            }
            catch (Exception) 
            {
                throw;
            }
            var result = new PagedResult<ApplicationUserViewModel>
            {
                Data = vmList,
                TotalItems = totalCount,
                PageNumber = pageNumber,
                PageSize = pageSize
            };
            return result;
        }

        private List<ApplicationUserViewModel> ConvertModelToViewModelList(List<ApplicationUser> modelList)
        {
            throw new NotImplementedException();
        }

        public ApplicationUserViewModel GetContactById(int ContactId)
        {
            var model = _unitOfWork.GenericRepository<ApplicationUser>().GetById(ContactId);
            var vm = new ApplicationUserViewModel(model);
            return vm;
        }

        public void InsertContact(ApplicationUserViewModel Contact)
        {
           var model = new ApplicationUserViewModel().ConvertViewModel(Contact);
            _unitOfWork.GenericRepository<ApplicationUser>().Add(model);
            _unitOfWork.Save();
        }

        public void UpdateContact(ApplicationUserViewModel contact)
        {
            var model = new ApplicationUserViewModel().ConvertViewModel(contact);
            var modelById = _unitOfWork.GenericRepository<ApplicationUser>().GetById(model.Id);
            modelById.Phone = contact.Phone;
            modelById.Email = contact.Email;
            modelById.HospitalId = contact.HospitalInfoId;

            _unitOfWork.GenericRepository<ApplicationUser>().Update(modelById);
            _unitOfWork.Save();
        }

        private List<ApplicationUserViewModel> ConvertModelToViewModelList(List<ApplicationUser> modelList)
        {
            return modelList.Select(x => new ApplicationUserViewModel(x)).ToList();
        }






    }
}
