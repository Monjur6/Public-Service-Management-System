using AutoMapper;
using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UserAppeal
    {
        public static List<UserAppealDTO> Get()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<User, UserDTO>();
                c.CreateMap<Service, ServiceDTO>();
                c.CreateMap<UserAppeal, UserAppealDTO>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<List<UserAppealDTO>>(DataAccessFactory.UserAppealDataAccess().Get());
            return data;
        }
    }
}
