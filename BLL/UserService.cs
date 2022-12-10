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
    public class UserService
    {
        public static List<UserDTO> Get()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<User, UserDTO>();
                c.CreateMap<Service, ServiceDTO>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<List<UserDTO>>(DataAccessFactory.UserDataAccess().Get()); 
            return data;
        }
        public static List<string> GetNames()
        {
            var data = DataAccessFactory.UserDataAccess().Get().Select(e=>e.Name).ToList();
            return data;
        }
        public static void Add(UserDTO u)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<UserDTO, User>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<User>(u);
            DataAccessFactory.UserDataAccess().Add(data);
        }
    }
}
