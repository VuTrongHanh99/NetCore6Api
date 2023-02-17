using AutoMapper;
using Data.SqlServer.Context;
using Data.SqlServer.Data;
using Microsoft.EntityFrameworkCore;
using NetCore.Domain.Entities;
using NetCore.Domain.Interfaces;

namespace MyApiNetCore6.Reponsitories
{
    public class VBCCRepository : IVBCCRepository
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public VBCCRepository(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        
        public async Task<int> AddVBCCAsync(VBCCModelEntity model)
        {
            var newVBCC = _mapper.Map<VBCC>(model);
            _context.VBCCs.Add(newVBCC);
            await _context.SaveChangesAsync();

            return newVBCC.Id;
        }

        public async Task DeleteVBCCAsync(int id)
        {
            var delete = _context.VBCCs.SingleOrDefault(b => b.Id == id);
            if (delete != null)
            {
                _context.VBCCs!.Remove(delete);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<VBCCModelEntity>> GetAllVBCCsAsync()
        {
            
            var resultList = await _context.VBCCs!.ToListAsync();
            foreach (var VBCC in resultList)
            {
                var hocVien = await _context.HocViens!.FindAsync(VBCC.HocVienId);
                VBCC.HocVien = hocVien;
            }
            return _mapper.Map<List<VBCCModelEntity>>(resultList);
        }

        public async Task<VBCCModelEntity> GetVBCCAsync(int id)
        {
            var result = await _context.VBCCs!.FindAsync(id);
            var hocVien= await _context.HocViens!.FindAsync(result.HocVienId);
            result.HocVien = hocVien;
            return _mapper.Map<VBCCModelEntity>(result);
        }

        public Task UpdateVBCCAsync(int id, VBCCModelEntity model)
        {
            throw new NotImplementedException();
        }
    }
}
