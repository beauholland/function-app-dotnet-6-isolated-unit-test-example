using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionApp1.Contracts.Responses
{
    public class FunctionPostEmployeeResponse
    {
        public string Id { get; set; } = default!;

        public string Title { get; set; } = default!;

        public string Body { get; set; } = default!;

        public DateTime LastUpdatedOn { get; set; }
    }
}
