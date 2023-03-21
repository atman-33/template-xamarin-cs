using Template.Services;

[assembly: Xamarin.Forms.Dependency(typeof(Template.Droid.Device))]
namespace Template.Droid
{
    internal sealed class Device : IDevice
    {
        public string GetDeviceName()
        {
            return "Android";
        }
    }
}