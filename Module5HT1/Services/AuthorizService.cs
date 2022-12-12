using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Module5HT1.Config;
using Module5HT1.Dtos.Request;
using Module5HT1.Dtos.Responses;
using Module5HT1.Services.Abstractions;

namespace Module5HT1.Services
{
    public class AuthorizService : IAuthoriseService
    {
        private readonly IInternalHttpClientService _httpClientService;
        private readonly ILogger<AuthorizService> _logger;
        private readonly ApiOption _options;
        private readonly string _registerApi = "api/register";
        private readonly string _loginApi = "api/login";

        public AuthorizService(
            IInternalHttpClientService httpClientService,
            IOptions<ApiOption> options,
            ILogger<AuthorizService> logger)
        {
            _httpClientService = httpClientService;
            _logger = logger;
            _options = options.Value;
        }

        public async Task<AuthorizResponse> Login(string email, string password)
        {
            var result = await _httpClientService.SendAsync<AuthorizResponse, AuthorizRequest>(
           $"{_options.Host}{_loginApi}",
           HttpMethod.Post,
           new AuthorizRequest()
           {
               Email = email,
               Password = password!
           });

            if (result != null)
            {
                _logger.LogInformation($"User with id = {result?.Id} was logined");
            }
            else
            {
                _logger.LogInformation($"User with id = {result?.Id} was not logined");
            }

            return result!;
        }

        public async Task<AuthorizResponse> Register(string email, string? password)
        {
            var result = await _httpClientService.SendAsync<AuthorizResponse, AuthorizRequest>(
           $"{_options.Host}{_registerApi}",
           HttpMethod.Post,
           new AuthorizRequest()
           {
               Email = email,
               Password = password!
           });

            if (result != null)
            {
                _logger.LogInformation($"User with id = {result?.Id} was registered");
            }
            else
            {
                _logger.LogInformation($"User with id = {result?.Id} was not registered");
            }

            return result!;
        }
    }
}
