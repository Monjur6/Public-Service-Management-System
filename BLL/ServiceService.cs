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
    public class ServiceService
    {
        public static List<ServiceDTO> Get()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<User, UserDTO>();
                c.CreateMap<Service, ServiceDTO>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<List<ServiceDTO>>(DataAccessFactory.ServiceDataAccess().Get());
            return data;
        }
        public static List<string> GetNames()
        {
            var data = DataAccessFactory.ServiceDataAccess().Get().Select(e => e.Name).ToList();
            return data;
        }
        public static void Add(ServiceDTO s)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<ServiceDTO, Service>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Service>(s);
            DataAccessFactory.ServiceDataAccess().Add(data);
        }
    }
}
