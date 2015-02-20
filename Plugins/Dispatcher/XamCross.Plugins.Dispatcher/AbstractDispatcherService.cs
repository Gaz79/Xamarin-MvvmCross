using System;
using System.Threading.Tasks;

namespace XamCross.Plugins.Dispatcher
{
    public abstract class AbstractDispatcherService : IDispatcherService
    {
        public abstract void InvokeUI(Action action);
    }
}