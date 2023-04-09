using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.Repositories
{
    public class GenericReporitory<T> : IGenericDal<T> where T : class
    {
        private readonly Context _contenxt;

        public GenericReporitory(Context contenxt)
        {
            _contenxt = contenxt;
        }

        public void Delete(T t)
        {
            _contenxt.Remove(t);
            _contenxt.SaveChanges();
        }

        public T GetByID(int id)
        {
            return _contenxt.Set<T>().Find();
        }

        public List<T> GetList()
        {
            return _contenxt.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            _contenxt.Add(t);
            _contenxt.SaveChanges();
        }

        public void Update(T t)
        {
            _contenxt.Update(t);
            _contenxt.SaveChanges();
        }
    }
}
