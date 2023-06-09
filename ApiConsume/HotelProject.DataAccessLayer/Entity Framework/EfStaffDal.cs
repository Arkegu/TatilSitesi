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
    public class EfStaffDal:GenericReporitory<Staff>, IStaffDal
    {
        public EfStaffDal(Context context) : base(context)
        {
            
        }
    }
}
