using Sabio.Models;
using Sabio.Models.Domain.TechCompanies;
using Sabio.Models.Requests.TechCompanies;


namespace Golden.Services.Interfaces
{
    public interface ITechCompanyService
    {
        Paged<TechCompany> GetPaginated(int pageIndex, int pageSize);

        Paged<TechCompany> GetPaginatedSearch(int pageIndex, int pageSize, string queryString);

        TechCompany GetById(int id);

        void SetStatus(int Id, string status);

        int Add(TechCompanyAddRequest newTechCompany, int UserId);

        void Update(TechCompanyUpdateRequest existingTechCompany, int UserId);
    }
}
