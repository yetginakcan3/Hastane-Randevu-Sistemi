﻿using Hospital.Utilities;
using Hospital.ViewModels;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Hospital.Services
{
    public interface IApplicationUserService
    {
        public PagedResult<ApplicationUserViewModel> GetAll(int pageNumber, int pageSize);

        public PagedResult<ApplicationUserViewModel> GetAllDoctor(int pageNumber, int pageSize);

        public PagedResult<ApplicationUserViewModel> GetAllPatient(int pageNumber, int pageSize);

        public PagedResult<ApplicationUserViewModel> SearchDoctor(int pageNumber, int pageSize,string Spicility=null);


    }
}