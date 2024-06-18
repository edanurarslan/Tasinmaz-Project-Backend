using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using tasinmaz.Dtos;
using tasinmaz.Models;

namespace tasinmaz.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Tasinmaz, TasinmazForDetailDto>()
                .ForMember(dest => dest.il, opt =>
                {
                    opt.MapFrom(src => src.il);
                })
                .ForMember(dest => dest.ilce, opt =>
                {
                    opt.MapFrom(src => src.ilce);
                })
                .ForMember(dest => dest.mahalle, opt =>
                {
                    opt.MapFrom(src => src.mahalle);
                });

            CreateMap<Tasinmaz, TasinmazForListDto>();
            CreateMap<Kullanici, KullaniciForDetailDto>();
            CreateMap<Log, LogForListDto>();
        }
    }
}
