using NetCore.Domain.Entities;

namespace NetCore.Domain.Interfaces
{
    public interface IHocVienRepository
    {
        public Task<List<HocVienModelEntity>> GetAllHocViensAsync();
        public Task<HocVienModelEntity> GetHocVienAsync(int id);
        public Task<int> AddHocVienAsync(HocVienModelEntity model);
        public Task UpdateHocVienAsync(int id, HocVienModelEntity model);
        public Task DeleteHocVienAsync(int id);
    }
}
