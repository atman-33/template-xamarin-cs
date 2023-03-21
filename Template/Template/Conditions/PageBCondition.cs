
namespace Template.Conditions
{
    /// <summary>
    /// PageBへの画面遷移時に渡すパラメータ定義クラス
    /// 【補足】
    /// 受け渡すパラメータが複数存在する場合は、このConditionで管理すると管理対象が明確化されるため便利
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
