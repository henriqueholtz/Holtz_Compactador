using System;
using Vip.Notification;

namespace Holtz_Compactador
{
    class CompactorException : Exception
    {
        public virtual string Title { get; set; }
        public CompactorException(string msg) : base(msg)
        {
            Title = "Erro!";
        }
        public CompactorException(string msg, string title) : base(msg)
        {
            Title = title;
        }
    }
}
