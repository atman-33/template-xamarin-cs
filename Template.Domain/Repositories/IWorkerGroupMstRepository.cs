using Template.Domain.Entities;
using System.Collections.Generic;

namespace Template.Domain.Repositories
{
    public interface IWorkerGroupMstRepository
    {
        IReadOnlyList<WorkerGroupMstEntity> GetData();

        void Save(WorkerGroupMstEntity entity);

        void Delete(WorkerGroupMstEntity entity);
    }
}
