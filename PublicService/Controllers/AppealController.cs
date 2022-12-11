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
    public class AppealController : ApiController
    {
        [Route("api/Appeal/AppliedFors")]
        [HttpGet]
        public List<string> GetAppliedFors()
        {
            return AppealService.GetAppliedFors();
        }
        [Route("api/Appeal/All")]
        [HttpGet]
        public List<AppealDTO> GetAll()
        {
            return AppealService.Get();
        }
        [Route("api/Appeal/Create")]
        [HttpPost]
        public void Add(AppealDTO ap)
        {
            AppealService.Add(ap);
        }
    }
}
