using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using tasinmaz.Models;
using tasinmaz.Data;

namespace tasinmaz.Data
{
    public class AppRepository : IAppRepository
    {
        private readonly DataContext _context;

        public AppRepository(DataContext context)
        {
            _context = context;
           
        }

        public List<Tasinmaz> GetAllTasinmaz()
        {
            var tasinmazlarim = _context.Tasinmazlar.ToList();
            return tasinmazlarim;
        }

        public List<Kullanici> GetAllKullanici()
        {
            var kullanicilarim = _context.Kullanicilar.ToList();
            return kullanicilarim;
        }

        public List<Log> GetAllLog()
        {
            var loglarim = _context.Loglar.ToList();
            Console.WriteLine(loglarim);
            return loglarim;
        }


        //public IEnumerable<Tasinmaz> GetAllTasinmaz()
        //{
        //  return _context.Tasinmazlar.ToList();
        //}

        public Tasinmaz GetByIdTasinmaz(int id)
        {
            return _context.Tasinmazlar.FirstOrDefault(c => c.Id == id);
            //return _context.Tasinmazlar.Find(id);
        }

        public Kullanici GetByIdKullanici(int id)
        {
            return _context.Kullanicilar.FirstOrDefault(c => c.Id == id);
            //return _context.Tasinmazlar.Find(id);
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
            _context.SaveChanges();
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
            _context.SaveChanges();
        }

        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
            _context.SaveChanges();
        }

        
        //public IEnumerable<Kullanici> GetAllKullanici()
        //{
          //  return _context.Kullanicilar.ToList();
        //}

        //public Kullanici GetByIdKullanici(int id)
        //{
          //  return _context.Kullanicilar.Find(id);
        //}

    }
}

   



   // public bool SaveAll()
      //  {
     //       return _context.SaveChanges() > 0;
        //}
    //}


        