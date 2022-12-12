using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Module5HT1.Config;
using Module5HT1.Dtos.Responses;
using Module5HT1.Dtos;
using Module5HT1.Services.Abstractions;

namespace Module5HT1.Services
{
    public class ResourceService : IResourceService
    {
        private readonly IInternalHttpClientService _httpClientService;
        private readonly ILogger<ResourceService> _logger;
        private readonly ApiOption _options;
        private readonly string _resourceApi = "api/unknown";
        public ResourceService(
            IInternalHttpClientService httpClientService,
            IOptions<ApiOption> options,
            ILogger<ResourceService> logger)
        {
            _httpClientService = httpClientService;
            _logger = logger;
            _options = options.Value;
        }

        public async Task<ListResponse<ResourceDto>> GetListResoursesByPage(int page)
        {
            var result = await _httpClientService.SendAsync<ListResponse<ResourceDto>, object>($"{_options.Host}{_resourceApi}", HttpMethod.Get);

            if (result != null)
            {
                _logger.LogInformation($"Resourses with page = {page} was found");
            }
            else
            {
                _logger.LogInformation($"Resourses with page = {page} was not found");
            }

            return result!;
        }

        public async Task<ResourceDto?> GetResourceById(int id)
        {
            var result = await _httpClientService.SendAsync<BaseResponse<ResourceDto>, object>($"{_options.Host}{_resourceApi}/{id}", HttpMethod.Get);
            if (result?.Data != null)
            {
                _logger.LogInformation($"Resource with id = {result.Data.Id} was found");
            }
            else
            {
                _logger.LogInformation($"Resource with id = {result?.Data?.Id} was not found");
            }

            return result?.Data;
        }
    }
}
