
namespace Template.Services
{
    /// 手順メモ
    /// 1:IDeviceインターフェースを作成（本クラス）
    /// 2:AndroidとUWPプロジェクト内にDeviceクラスを作成
    /// 3:ViewModel側で、DependencyService.Get<IDevice>()からメソッド実行

    /// <summary>
    /// デバイス毎に処理を切り替えるためのデバイス情報取得インターフェース
    /// </summary>
    public interface IDevice
    {
        string GetDeviceName();
    }
}
