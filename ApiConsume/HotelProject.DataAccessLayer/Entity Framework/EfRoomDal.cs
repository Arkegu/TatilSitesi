using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.Entity_Framework
{
    public class EfRoomDal:GenericReporitory<Room>, IRoomDal
    {
        public EfRoomDal(Context context) : base(context)
        {
            
        }
    }
}
