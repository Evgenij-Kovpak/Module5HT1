using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5HT1.Dtos.Responses
{
    public class BaseResponse<T>
        where T : class
    {
        public T Data { get; set; } = null!;
        public SupportDto Support { get; set; } = null!;
    }
}
