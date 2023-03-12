using System.Threading.Tasks;

namespace Template.Services
{
    public interface IQrScanningService
    {
        Task<string> ScanAsync();
    }
}
