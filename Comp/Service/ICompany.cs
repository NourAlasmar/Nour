using Comp.Model;

namespace Comp.Service
{
    public interface ICompany
    {
        Task<List<Company>> GetCompany();
        Task<Company> GetById(int id);
        Task<List<Company>> AddCompany(Company newCompany);
        Task<List<Company>> UpdateCompany(Company updateCompany);
        Task<List<Company>> DeleteCompany(int id);
    }
}
