using BLL;
using BEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PublicService.Controllers
{
    public class UserController : ApiController
    {
        [Route("api/User/Names")]
        [HttpGet]
        public List<string> GetNames()
        {
            return UserService.GetNames();
        }
        [Route("api/User/All")]
        [HttpGet]
        public List<UserDTO> GetAll()
        {
            return UserService.Get();
        }
        [Route("api/User/Create")]
        [HttpPost]
        public void Add(UserDTO u)
        {
            UserService.Add(u);
        }
    }
}
