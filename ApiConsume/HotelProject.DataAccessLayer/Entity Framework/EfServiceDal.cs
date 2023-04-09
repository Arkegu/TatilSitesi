﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.Entity_Framework
{
    public class EfServiceDal:GenericReporitory<Service>, IServicesDal
    {
        public EfServiceDal(Context context) : base(context)
        {
            
        }
    }
}
