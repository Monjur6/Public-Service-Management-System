using BEL;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PublicService.Controllers
{
    public class ServiceController : ApiController
    {
        [Route("api/Service/Names")]
        [HttpGet]
        public List<string> GetNames()
        {
            return ServiceService.GetNames();
        }
        [Route("api/Service/All")]
        [HttpGet]
        public List<ServiceDTO> GetAll()
        {
            return ServiceService.Get();
        }
        [Route("api/Service/Create")]
        [HttpPost]
        public void Add(ServiceDTO s)
        {
            ServiceService.Add(s);
        }
    }
}
