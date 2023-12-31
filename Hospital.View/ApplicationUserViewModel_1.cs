using Hospital.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.ViewModels
{
    public class ApplicationUserViewModel
    {
        public int Id { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int HospitalInfoId { get; set; }

        public ApplicationUserViewModel()
        {

        }

        public ApplicationUserViewModel(ApplicationUser model)
        {

            Id = model.Id;
            Phone = model.Phone;
            Email = model.Email;
            HospitalInfoId = model.HospitalId;
            
        }

        public ApplicationUser ConvertViewModel(ApplicationUserViewModel model)
        {
            return new ApplicationUser
            {

                Id = model.Id,
                Phone = model.Phone,
                Email = model.Email,
                HospitalId = model.HospitalInfoId,
            };
        }

    }
}
