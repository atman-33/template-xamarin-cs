using Template.Domain.ValueObjects;

namespace Template.Domain.Entities
{
    public sealed class WorkerGroupMstEntity
    {

        public WorkerGroupMstEntity(
            string workerGroupCode,
            string workerGroupName)
        {
            WorkerGroupCode = new WorkerGroupCode(workerGroupCode);
            WorkerGroupName = new WorkerGroupName(workerGroupName);
        }

        public WorkerGroupCode WorkerGroupCode { get; set; }
        public WorkerGroupName WorkerGroupName { get; set; }

    }
}
