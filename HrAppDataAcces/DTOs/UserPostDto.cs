using HrAppDataAcces.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrAppDataAcces.DTOs
{
    public class UserPostDto
    {
        public string Username { get; set; }

        public string Password { get; set; }
        public User toModel()
        {
            return new User()
            {
                Username = Username,
                Password = Password,
                Id = new Guid()
            };
        }
    }
}
