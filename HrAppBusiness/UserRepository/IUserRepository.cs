﻿using HrAppDataAcces.DTOs;
using HrAppDataAcces.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrAppBusiness.UserRepository
{
    public interface IUserRepository
    {
        Task<User> CreateUser(UserPostDto user);
    }
}
