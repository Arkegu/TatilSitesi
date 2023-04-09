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
    public class TestimonialManager : ITestimonialService
    {
        private readonly ITestimonialDal _testimonial;

        public TestimonialManager(ITestimonialDal testimonial)
        {
            _testimonial = testimonial;
        }

        public void TDelete(Testimonial t)
        {
            _testimonial.Delete(t);
        }

        public Testimonial TGetByID(int id)
        {
            return _testimonial.GetByID(id);
        }

        public List<Testimonial> TGetList()
        {
            return _testimonial.GetList();
        }

        public void TInsert(Testimonial t)
        {
            _testimonial.Insert(t);
        }

        public void TUpdate(Testimonial t)
        {
            _testimonial.Update(t);
        }
    }
}
