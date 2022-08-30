using Comp.Model;

namespace Comp.Service
{
    public class CompanyService : ICompany
    {

        private static List<Company> Companys = new List<Company>
        {
         new Company()
         {
             id=0,
             Name="Asal",
             Location="Ramllah"
         },
         new Company()
         {
             id = 1,
             Name = "iConnect",
             Location = "Ramllah"
         },
         new Company()
         {
             id = 3,
             Name = "AAUP",
             Location = "Jenin"
         }

        };
        public async Task<List<Company>> AddCompany(Company newCompany)
        {
            Companys.Add(newCompany);
            return Companys;
        }

        public async Task<List<Company>> DeleteCompany(int id)
        {
            Company Comp = Companys.First(x => x.id == id);
            Companys.Remove(Comp);
            return Companys;
        }

        public async Task<Company> GetById(int id)
        {
            return Companys.First(x => x.id == id);

        }

        public async Task<List<Company>> GetCompany()
        {
            return Companys;
        }

        public async Task<List<Company>> UpdateCompany(Company updateCompany)
        {
            Company c1 = Companys.First(x=> x.id == updateCompany.id);
            c1.Name=updateCompany.Name;
            c1.id = updateCompany.id;
            c1.Location = updateCompany.Location;
            return Companys;

        }
    }
}
