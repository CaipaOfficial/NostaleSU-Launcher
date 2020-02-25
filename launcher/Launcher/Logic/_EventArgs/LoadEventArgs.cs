using System;

namespace WowSuite.Launcher.Logic
{
    /// <summary>
    /// ������ ��������
    /// </summary>
    public class LoadEventArgs<TState, TResult> : EventArgs
        where TState : struct //��������������� ������������, ���������� ��������� ��������
        where TResult : class
    {
        /// <summary>
        /// �������������� ��������� ������ ������ �������������
        /// </summary>
        /// <param name="state">��������� ����������</param>
        /// <param name="result">������ ����������</param>
        public LoadEventArgs(TState state, TResult result)
        {
            State = state;
            Result = result;
        }

        /// <summary>
        /// ��������� �������������
        /// </summary>
        public TState State { get; protected set; }

        /// <summary>
        /// ������, ������� ������������ � �������� ����������
        /// </summary>
        public TResult Result { get; set; }
    }
}