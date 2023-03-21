using Template.Domain;
using Template.Domain.Repositories;
using Template.Infrastructure.Oracle;
using Template.Infrastructure.SQLite;

namespace Template2.Infrastructure
{
    /// <summary>
    /// Factories
    /// </summary>
    public static class Factories
    {
        public static void Open()
        {
#if DEBUG
            if (Shared.IsFake)
            {
                SQLiteHelper.Open();
                return;
            }
#endif
            OracleOdpHelper.Open();
        }

        public static IWorkerGroupMstRepository CreateWorkerGroupMst()
        {
#if DEBUG
            if (Shared.IsFake)
            {
                return new WorkerGroupMstSQLite();
            }
#endif
            return new WorkerGroupMstOracle();
        }
    }
}
