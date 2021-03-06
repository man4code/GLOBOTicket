using GloboTicket.Server.Data;
using GloboTicket.Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GloboTicket.Services
{
    public class UserService: IUserService
    {
        private readonly BookingsContext _userContext;
        public UserService(BookingsContext userContext)
        {
            _userContext = userContext;
        }

        public User GetUserDetails(int id)
        {
            var result = _userContext.User.Where(t => t.Id == id).FirstOrDefault();
            return result;
        }
    }
}
