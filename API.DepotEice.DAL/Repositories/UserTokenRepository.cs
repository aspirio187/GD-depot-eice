using API.DepotEice.DAL.Entities;
using API.DepotEice.DAL.IRepositories;
using AutoMapper;
using DevHopTools.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.DepotEice.DAL.Repositories
{
    public class UserTokenRepository : IUserTokenRepository
    {
        private readonly IMapper _mapper;
        private readonly Connection _connection;

        public UserTokenRepository(IMapper mapper, Connection connection)
        {
            if (mapper is null)
            {
                throw new ArgumentNullException(nameof(mapper));
            }

            if (connection is null)
            {
                throw new ArgumentNullException(nameof(connection));
            }

            _mapper = mapper;
            _connection = connection;
        }

        public string Create(UserTokenEntity entity)
        {
            if (entity is null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            Command command = new Command("spCreateUserToken", true);

            command.AddParameter("type", entity.Type);
            command.AddParameter("expirationDate", entity.ExpirationDateTime);
            command.AddParameter("userId", entity.UserId);
            command.AddParameter("userSecurityStamp", entity.)
        }

        public bool Delete(UserTokenEntity entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserTokenEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public UserTokenEntity? GetByKey(string key)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserTokenEntity> GetUserTokens(string userId)
        {
            throw new NotImplementedException();
        }

        public bool Update(UserTokenEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
