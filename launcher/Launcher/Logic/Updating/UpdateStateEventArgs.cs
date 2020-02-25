using System;

namespace WowSuite.Launcher.Logic.Updating
{
    /// <summary>
    /// ��������� ������� ��������� ��������� �������� ����������.
    /// </summary>
    public class UpdateStateEventArgs : EventArgs
    {
        public UpdateStateEventArgs(UpdateState newState, UpdateState oldState)
        {
            NewState = newState;
            OldState = oldState;
        }

        /// <summary>
        /// ����� ���������
        /// </summary>
        public UpdateState NewState { get; protected set; }

        /// <summary>
        /// ������ ���������
        /// </summary>
        public UpdateState OldState { get; protected set; }
    }
}