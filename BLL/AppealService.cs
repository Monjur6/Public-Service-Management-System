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
     public class AppealService
    {
        public static List<AppealDTO> Get()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<User, UserDTO>();
                c.CreateMap<Service, ServiceDTO>();
                c.CreateMap<Appeal, AppealDTO>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<List<AppealDTO>>(DataAccessFactory.AppealDataAccess().Get());
            return data;
        }
        public static List<string> GetAppliedFors()
        {
            var data = DataAccessFactory.AppealDataAccess().Get().Select(e => e.AppliedFor).ToList();
            return data;
        }
        public static void Add(AppealDTO u)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<AppealDTO, Appeal>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Appeal>(u);
            DataAccessFactory.AppealDataAccess().Add(data);
        }
    }
}
