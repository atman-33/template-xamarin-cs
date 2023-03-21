namespace Template.Domain
{
    /// <summary>
    /// Shared
    /// </summary>
    public static class Shared
    {
        /// <summary>
        /// Fakeの時Trure（1:Fake）
        /// </summary>
        public static bool IsFake { get; } = true;

        /// <summary>
        /// SQLite 接続子
        /// </summary>
        public static string SQLiteConnectionString { get; } = @"C:\Repos\template-xamarin-cs\Fake\SQLite.db";

        public static string OracleUser { get; } = "atman";
        public static string OraclePassword { get; } = "atman";
        public static string OracleDataSource { get; } 
            = @"(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = TESTDB.GRAWOR)))";
    }
}