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
    public class TasinmazsController : ControllerBase
    {
        private IAppRepository _appRepository;
        private IMapper _mapper;

        public TasinmazsController(IAppRepository appRepository, IMapper mapper)
        {
            _appRepository = appRepository;
            _mapper = mapper;
        }


        [HttpPost]
        [Route("add")]
        public ActionResult Add([FromBody] Tasinmaz tasinmaz)
        {
            _appRepository.Add(tasinmaz);
            return Ok(tasinmaz);

        }

        /*[HttpDelete]
        [Route("delete")]
        public ActionResult Delete(int id)
        {
            _appRepository.Delete(id);
            return Ok(id);
        }
        */

        [HttpDelete]
        [Route("delete")]
        public ActionResult Delete(int id)
        {
            var tasinmazFromRepo = _appRepository.GetByIdTasinmaz(id);
            _appRepository.Delete(tasinmazFromRepo);
            return Ok(id);
        }
        


        [HttpPut]
        [Route("update")]
        public ActionResult Update([FromBody] Tasinmaz tasinmaz)
        {
            _appRepository.Update(tasinmaz);
            return Ok(tasinmaz);

        }


        [HttpGet]
        [Route("detail")]
        public ActionResult GetByIdTasinmaz(int id)
        {
            var tasinmaz = _appRepository.GetByIdTasinmaz(id);
            var tasinmazToReturn = _mapper.Map<TasinmazForDetailDto>(tasinmaz);
            return Ok(tasinmazToReturn);
        }

        [HttpGet]
        [Route("all")]
        public ActionResult GetAllTasinmaz()
        {
            var tasinmaz = _appRepository.GetAllTasinmaz();
            var tasinmazToReturn = _mapper.Map<List<TasinmazForListDto>>(tasinmaz);
            return Ok(tasinmazToReturn);
        }


    }
}



   

