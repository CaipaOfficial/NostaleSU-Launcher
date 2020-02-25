using WowSuite.Utils;

namespace WowSuite.Launcher.Logic
{
    /// <summary>
    /// ������ �������� � ���� ������
    /// </summary>
    public class LoadTextEventArgs : LoadEventArgs<LoadingState, QueryResult<string>>
    {
        /// <summary>
        /// �������������� ��������� ������ ������ �������� ��������
        /// </summary>
        /// <param name="state">��������� ��������</param>
        /// <param name="result">���������</param>
        public LoadTextEventArgs(LoadingState state, QueryResult<string> result)
            : base(state, result)
        {
        }
    }
}