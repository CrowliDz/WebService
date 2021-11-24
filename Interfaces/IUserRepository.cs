using System.Collections.Generic;
using System.Threading.Tasks;
using WebService.DTOs;
using WebService.Entities;
using WebService.Helpers;

namespace WebService.Interfaces
{
    //Repository Design Pattern
    public interface IUserRepository
    {
        void Update(AppUser user);
        Task<bool> SaveAllAsync();
        Task<IEnumerable<AppUser>> GetUsersAsync();
        Task<AppUser> GetUserByIdAsync(int id);
        Task<AppUser> GetUserByUsernameAsync(string username);
        Task<PagedList<MemberDto>> GetMembersAsync(UserParams userParams);
        Task<MemberDto> GetMemberAsync(string username);
    }
}