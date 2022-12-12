using Module5HT1.Dtos.Responses;
using Module5HT1.Dtos;

namespace Module5HT1.Services.Abstractions
{
    public interface IResourceService
    {
        Task<ResourceDto?> GetResourceById(int id);
        Task<ListResponse<ResourceDto>> GetListResoursesByPage(int page);
    }
}
