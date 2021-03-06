using API.DepotEice.DAL.Entities;
using API.DepotEice.DAL.IRepositories;
using AutoMapper;
using DepotEice.Shared.Exceptions;
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

        /// <inheritdoc/>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="DatabaseScalarNullException"></exception>
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
            command.AddParameter("userSecurityStamp", entity.UserSecurityStamp);

            string? scalarResult = _connection.ExecuteScalar(command).ToString();

            if (string.IsNullOrEmpty(scalarResult))
            {
                throw new DatabaseScalarNullException(nameof(scalarResult));
            }

            return scalarResult;
        }

        /// <inheritdoc/>
        /// <exception cref="ArgumentNullException"></exception>
        public bool Delete(UserTokenEntity entity)
        {
            if (entity is null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            Command command = new Command("spDeleteUserToken", true);

            command.AddParameter("id", entity.Id);

            return _connection.ExecuteNonQuery(command) > 0;
        }

        /// <summary>
        /// Not implemented
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public IEnumerable<UserTokenEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        /// <exception cref="ArgumentNullException"></exception>
        public UserTokenEntity? GetByKey(string key)
        {
            if (string.IsNullOrEmpty(key))
            {
                throw new ArgumentNullException(nameof(key));
            }

            Command command = new Command("spGetUserToken", true);

            command.AddParameter("id", key);

            return _connection
                .ExecuteReader(command, userToken => _mapper.Map<UserTokenEntity>(userToken))
                .SingleOrDefault();
        }

        public IEnumerable<UserTokenEntity> GetUserTokens(string userId)
        {
            if (string.IsNullOrEmpty(userId))
            {
                throw new ArgumentNullException(nameof(userId));
            }

            Command command = new Command("spGetUserTokens", true);

            command.AddParameter("userId", userId);

            return _connection
                .ExecuteReader(command, userToken => _mapper.Map<UserTokenEntity>(userToken));
        }

        /// <summary>
        /// Not implemented
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool Update(UserTokenEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
