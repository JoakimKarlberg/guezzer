using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace guezzer.Api.Helpers
{
    public class GetResultDto
    {
        public Guid ResultId { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int Score { get; set; }
    }
}
