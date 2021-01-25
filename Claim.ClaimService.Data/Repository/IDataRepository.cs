using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Claim.ClaimService.Data.Repository
{
    public interface IDataRepository<T> where T : class
    {

        Task<T> GetById(Int64 id);

        Task Create(T entity);

        void Delete(T entity);

        void Update(T entity);

        Task<List<T>> GetAll();

    }
}
