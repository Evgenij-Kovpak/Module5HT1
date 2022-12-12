using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module5HT1.Dtos.Responses;

namespace Module5HT1.Services.Abstractions
{
    public interface IAuthoriseService
    {
        Task<AuthorizResponse> Register(string email, string? password);
        Task<AuthorizResponse> Login(string email, string password);
    }
}
