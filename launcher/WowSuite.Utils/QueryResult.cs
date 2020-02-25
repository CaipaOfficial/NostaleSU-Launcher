namespace WowSuite.Utils
{
    /// <summary>
    /// ������������ �� ���� ��������� ������� (��������, � ��������� ������� �� ������-�� �������)
    /// </summary>
    /// <typeparam name="TData">������, ������������ � ������ ��������� ���������� �������</typeparam>
    public class QueryResult<TData>
    {
        public QueryResult(bool success, TData data)
        {
            Success = success;
            Data = data;
        }

        /// <summary>
        /// ������, ������������ � ������ ������ ���������� ��������
        /// </summary>
        public TData Data { get; set; }

        /// <summary>
        /// �������� ������� ���������
        /// </summary>
        public bool Success { get; set; }
    }
}