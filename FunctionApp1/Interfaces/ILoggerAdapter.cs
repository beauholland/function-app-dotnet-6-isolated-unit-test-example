using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionApp1.Interfaces
{
    public interface ILoggerAdapter<TType>
    {
        void LogError(Exception exception, string message);
        void LogError(string message);
        void LogInformation(string message);
    }
}
