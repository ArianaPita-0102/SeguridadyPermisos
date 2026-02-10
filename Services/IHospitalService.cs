using Security.Models;
using Security.Models.DTOS;

namespace Security.Services
{
    public interface IHospitalService
    {
        Task<IEnumerable<Hospital>> GetAll();
        Task<Hospital> GetOne(Guid id);
        Task<Hospital> CreateHospital(CreateHospitalDto dto);

        // Update Method
        Task<Hospital?> UpdateHospital(UpdateHospitalDto dto);
        //delete method
        Task<bool> DeleteHospital(Guid id);

        // Get all hospitals by types
        Task<IEnumerable<Hospital>> GetAllByTypes(IEnumerable<int> types);
    }
}
