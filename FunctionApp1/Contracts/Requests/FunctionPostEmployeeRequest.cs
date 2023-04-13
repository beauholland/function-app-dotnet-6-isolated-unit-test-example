using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionApp1.Contracts.Requests
{
    public class FunctionPostEmployeeRequest
    {
        public string Title { get; init; } = default!;

        public string Body { get; init; } = default!;
    }
}
