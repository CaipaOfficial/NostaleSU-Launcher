namespace WowSuite.Launcher.Logic.Updating
{
    /// <summary>
    /// ������������� ����� ��������, ������������, � ����� ��������� ��������� ��������.
    /// </summary>
    public enum UpdateState
    {
        /// <summary>������ �� ������</summary>
        None,

        /// <summary>��������� ������� ����������</summary>
        Checking,

        /// <summary>���������� ��������</summary>
        Started,

        /// <summary>���������� �� ���������</summary>
        NotNeeded,

        /// <summary>���������� ������� ���������</summary>
        Completed
    }
}