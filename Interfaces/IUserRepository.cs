using System.Collections.Generic;
using System.Threading.Tasks;
using WebService.DTOs;
using WebService.Entities;

namespace WebService.Interfaces
{
    public interface IUserRepository //Sirve para abstraer el acceso a los metodos que mantienen las operaciones CRUD de la db.
    {
        void Update(AppUser user);
        Task<bool> SaveAllAsync();
        Task<IEnumerable<AppUser>> GetUsersAsync();
        Task<AppUser> GetUserByIdAsync(int id);
        Task<AppUser> GetUserByUsernameAsync(string username);
        Task<IEnumerable<MemberDto>> GetMembersAsync();
        Task<MemberDto> GetMemberAsync(string username);
    }
}
