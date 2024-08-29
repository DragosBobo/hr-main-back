using HrAppDataAcces;
using HrAppDataAcces.DTOs;
using HrAppDataAcces.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrAppBusiness.UserRepository
{
    public class UserRepository : IUserRepository
    {
        private readonly DataBaseContext _context;
        public UserRepository(DataBaseContext context)
        {
            _context = context;
        }
        public Task<User> CreateUser(UserPostDto user)
        {
            var entity = user.toModel();
            _context.Users.Add(entity);
            _context.SaveChanges();
            return Task.FromResult(entity);
        }
    }
}
