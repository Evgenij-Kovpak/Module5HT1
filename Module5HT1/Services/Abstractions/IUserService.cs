using Module5HT1.Dtos.Responses;
using Module5HT1.Dtos;

namespace Module5HT1.Services.Abstractions
{
    public interface IUserService
    {
        Task<UserDto?> GetUserById(int id);
        Task<ListResponse<UserDto>> GetListUsersByPage(int page);
        Task<ListResponse<UserDto>> GetListUsersDelay(int delay);
        Task<UserResponse> CreateUser(string name, string job);
        Task<UserResponse> UpdateUser(int id, string name, string job);
        Task<bool> DeleteUser(int id);
    }
}
