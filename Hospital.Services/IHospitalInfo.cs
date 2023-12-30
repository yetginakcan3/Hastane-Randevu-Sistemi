using Hospital.Utilities;
using Hospital.ViewModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Services
{
	public interface IHospitalInfo
	{
		PagedResult<HospitalInfoViewModel> GetAll(int pageNumber, int pageSize);
		HospitalInfoViewModel GetHospitalById(int Hospitalid);
		void UpdateHospitalInfo(HospitalInfoViewModel hospitalInfo);
		void DeleteHospitalInfo(int id);
		void InsertHospitalInfo(HospitalInfoViewModel HospitalInfo);
        IEnumerable GetAll();
    }
}
