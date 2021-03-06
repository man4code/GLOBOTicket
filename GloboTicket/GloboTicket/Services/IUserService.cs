using GloboTicket.Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GloboTicket.Services
{
    public interface IUserService
    {
        User GetUserDetails(int id);
    }
}
