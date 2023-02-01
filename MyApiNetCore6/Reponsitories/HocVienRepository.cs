using AutoMapper;
using Data.SqlServer.Context;
using Data.SqlServer.Data;
using Microsoft.EntityFrameworkCore;
using NetCore.Domain.Entities;
using NetCore.Domain.Interfaces;

namespace MyApiNetCore6.Reponsitories
{
    public class HocVienRepository : IHocVienRepository
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public HocVienRepository(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<int> AddHocVienAsync(HocVienModelEntity model)
        {
            var newHocVien=_mapper.Map<HocVien>(model);
            _context.HocViens.Add(newHocVien);
            await _context.SaveChangesAsync();

            return newHocVien.Id;
        }

        public async Task DeleteHocVienAsync(int id)
        {
            var delete=_context.HocViens.SingleOrDefault(b=>b.Id==id);
            if (delete != null)
            {
                _context.HocViens!.Remove(delete);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<HocVienModelEntity>> GetAllHocViensAsync()
        {
            var result = await _context.HocViens!.ToListAsync();
            return _mapper.Map<List<HocVienModelEntity>>(result);
        }

        public  async Task<HocVienModelEntity> GetHocVienAsync(int id)
        {
            var result = await _context.HocViens!.FindAsync(id);
            return _mapper.Map<HocVienModelEntity>(result);
        }

        public async Task UpdateHocVienAsync(int id, HocVienModelEntity model)
        {
            if (id == model.Id)
            {
                var update = _mapper.Map<HocVien>(model);
                _context.HocViens!.Update(update);
                await _context.SaveChangesAsync();
            }
        }
    }
}
