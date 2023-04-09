using HotelProject.BusinessLayer.Abbstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class StaffManager : IStaffService
    {
        private readonly IStaffDal _staff;

        public StaffManager(IStaffDal staff)
        {
            _staff = staff;
        }

        public void TDelete(Staff t)
        {
            _staff.Delete(t);
        }

        public Staff TGetByID(int id)
        {
           return _staff.GetByID(id);
        }

        public List<Staff> TGetList()
        {
            return _staff.GetList();
        }

        public void TInsert(Staff t)
        {
            _staff.Insert(t);
        }

        public void TUpdate(Staff t)
        {
            _staff.Update(t);
        }
    }
}
