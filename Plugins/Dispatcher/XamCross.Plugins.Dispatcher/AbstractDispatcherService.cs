using System;
using System.Threading.Tasks;

namespace XamCross.Plugins.Dispatcher
{
    public abstract class AbstractDispatcherService : IDispatcherService
    {
        public virtual async Task InvokeUi(Action action)
        {
        }
    }
}