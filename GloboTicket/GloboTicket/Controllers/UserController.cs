using GloboTicket.Server.Models;
using GloboTicket.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GloboTicket.Controllers
{
    public class UserController: ControllerBase
    {
        private readonly IUserService userService;
        public UserController(IUserService _userService)
        {
            userService = _userService;
        }

        [HttpGet]
        public User GetUserDetails(int id)
        {
            var result = userService.GetUserDetails(id);
            return result;
        }
    }
}
