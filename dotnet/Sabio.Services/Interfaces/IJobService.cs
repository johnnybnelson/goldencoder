using Sabio.Models.Domain.Jobs;
using Sabio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sabio.Models.Requests.Jobs;

namespace Sabio.Services.Interfaces
{
    public interface IJobService
    {

        Paged<Job> GetPaginated(int pageIndex, int pageSize);
        
        Paged<Job> GetPaginatedSearch(int pageIndex, int pageSize, string queryString);

        Job GetById(int id);

        void SetStatus(int Id, string status);

        int Add(JobAddRequest newJob, int UserId);

        void Update(JobUpdateRequest existingJob, int UserId);

    }
}
