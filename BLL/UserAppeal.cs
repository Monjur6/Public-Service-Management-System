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
        //public static List<string> GetNames()
        //{
        //    var data = DataAccessFactory.UserAppealDataAccess().Get().Select(e => e.Name).ToList();
        //    return data;
        //}
        //public static void Add(UserAppealDTO u)
        //{
        //    var config = new MapperConfiguration(c =>
        //    {
        //        c.CreateMap<UserAppealDTO, UserAppeal>();
        //    });
        //    var mapper = new Mapper(config);
        //    var data = mapper.Map<UserAppeal>(u);
        //    DataAccessFactory.UserAppealDataAccess().Add(data);
        //}
    }
}
