using Certify.Core;
using Certify.Repositories.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certify.Repositories
{
    public class UserRepository
    {
        private readonly CertifyDbContext _ctx;
        private readonly UserManager<User> _userManager;
        public UserRepository(CertifyDbContext ctx/*, UserManager<User> userManager*/)
        {
            _ctx = ctx;
           // _userManager = userManager;
        }
        public async Task<IEnumerable<UserModel>> GetUsersListAsync()
        {
            var list = await _ctx.Users.Select(x => new UserModel
            {
                Id = x.Id,
                Name = x.UserName/*,
                Roles = _userManager.GetRolesAsync(x).Result.ToList()*/
            }).ToListAsync();

            return list;
        }
        
        public async Task CreateUser(User user, string password, List<string> roles)
        {
            PasswordHasher<User> hasher = new PasswordHasher<User>();
            var result = await _userManager.CreateAsync(user, password);

            if(result == IdentityResult.Success)
            {
                await _userManager.AddToRolesAsync(_ctx.Users.First(x => x.UserName == user.UserName), roles);               
            }
        }

        public async Task<List<KeyValuePair<string, string>>> GetRolesListAsync()
        {
            return await _ctx.Roles.Select(x => new KeyValuePair<string, string>(x.Id, x.Name)).ToListAsync();
        }


    }
}
