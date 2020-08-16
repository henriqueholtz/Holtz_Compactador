using System;
using Vip.Notification;

namespace Holtz_Compactador
{
    class CompactorException : Exception
    {
        public CompactorException(string msg) : base(msg)
        {
            //Alert.ShowError(msg);
        }
    }
}
