using NetCore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCore.Domain.Interfaces
{
    public interface IVBCCRepository
    {
        public Task<List<VBCCModelEntity>> GetAllVBCCsAsync();
        public Task<VBCCModelEntity> GetVBCCAsync(int id);
        public Task<int> AddVBCCAsync(VBCCModelEntity model);
        public Task UpdateVBCCAsync(int id, VBCCModelEntity model);
        public Task DeleteVBCCAsync(int id);
    }
}
