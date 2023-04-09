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
    public class ServiceManager : IServiceService
    {
        private readonly IServicesDal _servicesdal;

        public ServiceManager(IServicesDal servicesdal)
        {
            _servicesdal = servicesdal;
        }

        public void TDelete(Service t)
        {
            _servicesdal.Delete(t);
        }

        public Service TGetByID(int id)
        {
            return _servicesdal.GetByID(id);    
        }

        public List<Service> TGetList()
        {
            return _servicesdal.GetList();
        }

        public void TInsert(Service t)
        {
            _servicesdal.Insert(t);
        }

        public void TUpdate(Service t)
        {
            _servicesdal.Update(t);
        }
    }
}
