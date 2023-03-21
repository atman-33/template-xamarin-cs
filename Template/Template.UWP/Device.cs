using Template.Services;

[assembly: Xamarin.Forms.Dependency(typeof(Template.UWP.Device))]
namespace Template.UWP
{
    internal sealed class Device : IDevice
    {
        public string GetDeviceName()
        {
            return "UWP";
        }
    }
}
