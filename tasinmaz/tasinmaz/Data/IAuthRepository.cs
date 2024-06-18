using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tasinmaz.Data;
using tasinmaz.Models;

namespace tasinmaz.Data
{
    public interface IAuthRepository
    {
        Task<Kullanici> Register(Kullanici user, string password);
        Task<Kullanici> Login(string kullaniciad, string password);
        Task<bool> UserExists(string kullaniciad);
    }
}
