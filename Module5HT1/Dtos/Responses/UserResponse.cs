using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5HT1.Dtos.Responses
{
    public class UserResponse
    {
        public string Name { get; set; } = null!;
        public string Job { get; set; } = null!;
        public int Id { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }
    }
}
