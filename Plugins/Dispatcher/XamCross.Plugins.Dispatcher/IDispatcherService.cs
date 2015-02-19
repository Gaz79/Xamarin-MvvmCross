using System;
using System.Threading.Tasks;

namespace XamCross.Plugins.Dispatcher
{
    public interface IDispatcherService
    {
        Task InvokeUi(Action action);
    }
}