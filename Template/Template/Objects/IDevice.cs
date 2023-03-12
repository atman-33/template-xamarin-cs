
namespace Template.Objects
{
    /// デバイス毎に処理を切り替える際に使用
    /// 1:IDeviceインターフェースを作成（本クラス）
    /// 2:AndroidとUWPプロジェクト内にDeviceクラスを作成
    /// 3:ViewModel側で、DependencyService.Get<IDevice>()からメソッド実行

    /// <summary>
    /// 
    /// </summary>
    public interface IDevice
    {
        string GetDeviceName();
    }
}
