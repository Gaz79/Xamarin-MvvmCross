using System;
using System.Threading.Tasks;

namespace XamCross.Plugins.Dispatcher
{
    public interface IDispatcherService
    {
        void InvokeUI(Action action);
    }
}