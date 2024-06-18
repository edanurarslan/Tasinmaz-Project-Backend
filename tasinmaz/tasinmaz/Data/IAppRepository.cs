using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tasinmaz.Data;
using tasinmaz.Models;

namespace tasinmaz.Data
{
    public interface IAppRepository
    {
        List<Tasinmaz> GetAllTasinmaz();
        Tasinmaz GetByIdTasinmaz(int id);

        List<Kullanici> GetAllKullanici();
        Kullanici GetByIdKullanici(int id);

        List<Log> GetAllLog();

        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;

       // IEnumerable<Kullanici> GetAllKullanici();

        //Kullanici GetByIdKullanici(int id);

    }
}
