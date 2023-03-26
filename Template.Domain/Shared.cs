using Xamarin.Essentials;

namespace Template.Domain
{
    public static class Shared
    {
        public static bool IsFake
        {
            get => Preferences.Get(nameof(IsFake), false);
            set => Preferences.Set(nameof(IsFake), value);
        }

        public static string SQLiteConnectionString
        {
            get => Preferences.Get(nameof(SQLiteConnectionString), @"C:\Repos\template-xamarin-cs\Fake\SQLite.db");
            set => Preferences.Set(nameof(SQLiteConnectionString), value);
        }

        public static string OracleUser
        {
            get => Preferences.Get(nameof(OracleUser), "atman");
            set => Preferences.Set(nameof(OracleUser), value);
        }

        public static string OraclePassword
        {
            get => Preferences.Get(nameof(OraclePassword), "atman");
            set => Preferences.Set(nameof(OraclePassword), value);
        }

        public static string OracleHost
        {
            get => Preferences.Get(nameof(OracleHost), "192.168.3.16");
            set => Preferences.Set(nameof(OracleHost), value);
        }

        public static string OracleServiceName
        {
            get => Preferences.Get(nameof(OracleServiceName), "XEPDB1");
            set => Preferences.Set(nameof(OracleServiceName), value);
        }

        public static string OracleDataSource
        {
            get => $"(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = {OracleHost})(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = {OracleServiceName})))";
        }
    }
}
