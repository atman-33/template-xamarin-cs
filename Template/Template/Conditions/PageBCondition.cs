
namespace Template.Conditions
{
    /// <summary>
    /// PageBへの画面遷移時に渡すパラメータ定義クラス
    /// </summary>
    internal sealed class PageBCondition
    {
        public PageBCondition(string title)
        {
            Title = title;
        }

        public string Title { get; }
    }
}
