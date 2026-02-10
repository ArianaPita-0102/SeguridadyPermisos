using Security.Models;

namespace Security.Repositories
{
    public interface IHospitalRepository
    {
        Task<IEnumerable<Hospital>> GetAll();
        Task<Hospital> GetOne(Guid id);
        Task Add(Hospital hospital);

        //Update Method
        Task Update(Hospital hospital);

        //Delete Method
        Task Delete(Hospital hospital);

        // Get all hospitals by types
        Task<IEnumerable<Hospital>> GetAllByTypes(IEnumerable<int> types);
    }
}
