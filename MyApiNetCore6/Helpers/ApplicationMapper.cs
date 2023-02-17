using AutoMapper;
using Data.SqlServer.Data;
using NetCore.Domain.Entities;

namespace MyApiNetCore6.Helpers
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper()
        {
            //map 2 đảo chiều sử dụng các tên view tương đương
            CreateMap<Book, BookModelEntity>().ReverseMap();
            CreateMap<HocVien, HocVienModelEntity>().ReverseMap();
            CreateMap<VBCC, VBCCModelEntity>().ReverseMap();
        }
    }
}
