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
    public class LogsController : ControllerBase
    {
        private IAppRepository _appRepository;
        private IMapper _mapper;

        public LogsController(IAppRepository appRepository, IMapper mapper)
        {
            _appRepository = appRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("all")]
        public ActionResult GetAllLog()
        {
            var log = _appRepository.GetAllLog();
            var logToReturn = _mapper.Map<List<LogForListDto>>(log);
            return Ok(logToReturn);
        }

        [HttpPost]
        [Route("add")]
        public ActionResult Add([FromBody] Log log)
        {
            _appRepository.Add(log);
            return Ok(log);

        }
    }
}
