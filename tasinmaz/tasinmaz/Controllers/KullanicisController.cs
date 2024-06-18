using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using tasinmaz.Data;
using tasinmaz.Dtos;
using tasinmaz.Models;

namespace tasinmaz.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KullanicisController : ControllerBase
    {
        private IAppRepository _appRepository;
        private IMapper _mapper;

        public KullanicisController(IAppRepository appRepository, IMapper mapper)
        {
            _appRepository = appRepository;
            _mapper = mapper;
        }


        /* [HttpPost]
         [Route("add")]
         public ActionResult Add([FromBody] UserForRegisterDto kullanici)
         {
             _appRepository.Add(kullanici);
             return Ok(kullanici);

         }

         */

        [HttpDelete]
        [Route("delete")]
        public ActionResult Delete(int id)
        {
            var kullaniciFromRepo = _appRepository.GetByIdKullanici(id);
            _appRepository.Delete(kullaniciFromRepo);
            return Ok(id);
        }



        /* [HttpPut]
         [Route("update")]
         public ActionResult Update([FromBody] Kullanici kullanici)
         {
             _appRepository.Update(kullanici);
             return Ok(kullanici);

         }
         */

        [HttpGet]
        [Route("detail")]
        public ActionResult GetByIdKullanici(int id)
        {
            var kullanici = _appRepository.GetByIdKullanici(id);
            var kullaniciToReturn = _mapper.Map<KullaniciForDetailDto>(kullanici);
            return Ok(kullaniciToReturn);
        }

        [HttpGet]
        [Route("all")]
        public ActionResult GetAllKullanici()
        {
            var kullanici = _appRepository.GetAllKullanici();
            var kullaniciToReturn = _mapper.Map<List<KullaniciForDetailDto>>(kullanici);
            return Ok(kullaniciToReturn);
        }



    }
}





