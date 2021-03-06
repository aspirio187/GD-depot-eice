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
    /// <summary>
    /// Repository for <see cref="RoleEntity"/>
    /// </summary>
    public class RoleRepository : IRoleRepository
    {
        private readonly IMapper _mapper;
        private readonly Connection _connection;

        public RoleRepository(IMapper mapper, Connection connection)
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

        /// <summary>
        /// Add a <see cref="UserEntity"/> to a <see cref="RoleEntity"/>
        /// </summary>
        /// <param name="id">
        /// <see cref="RoleEntity"/>'s ID
        /// </param>
        /// <param name="userId">
        /// <see cref="UserEntity"/>'s ID
        /// </param>
        /// <returns>
        /// <c>true</c> If <see cref="UserEntity"/> has successfully been added to the 
        /// <see cref="RoleEntity"/>
        /// </returns>
        /// <exception cref="ArgumentNullException"></exception>
        public bool AddUser(string id, string userId)
        {
            if (string.IsNullOrEmpty(id))
            {
                throw new ArgumentNullException(nameof(id));
            }

            if (string.IsNullOrEmpty(userId))
            {
                throw new ArgumentNullException(nameof(userId));
            }

            Command command = new Command("spAddUserToRole", true);

            command.AddParameter("roleId", id);
            command.AddParameter("userId", userId);

            return _connection.ExecuteNonQuery(command) > 0;
        }

        /// <inheritdoc/>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="DatabaseScalarNullException"></exception>
        public string Create(RoleEntity entity)
        {
            if (entity is null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            Command command = new Command("spCreateRole", true);

            command.AddParameter("name", entity.Name);

            string? scalarResult = _connection.ExecuteScalar(command).ToString();

            if (string.IsNullOrEmpty(scalarResult))
            {
                throw new DatabaseScalarNullException(nameof(scalarResult));
            }

            return scalarResult;
        }

        /// <inheritdoc/>
        /// <exception cref="ArgumentNullException"></exception>
        public bool Delete(RoleEntity entity)
        {
            if (entity is null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            Command command = new Command("spDeleteRole", true);

            command.AddParameter("id", entity.Id);

            return _connection.ExecuteNonQuery(command) > 0;
        }

        public IEnumerable<RoleEntity> GetAll()
        {
            string query = "SELECT * FROM [dbo].[Roles]";

            Command command = new Command(query);

            return _connection.ExecuteReader(command, role => _mapper.Map<RoleEntity>(role));
        }

        /// <inheritdoc/>
        /// <exception cref="ArgumentNullException"></exception>
        public RoleEntity? GetByKey(string key)
        {
            if (string.IsNullOrEmpty(key))
            {
                throw new ArgumentNullException(nameof(key));
            }

            Command command = new Command("spGetRole", true);

            command.AddParameter("id", key);

            return _connection
                .ExecuteReader(command, role => _mapper.Map<RoleEntity>(role))
                .SingleOrDefault();

        }

        /// <summary>
        /// Retrieve all <see cref="RoleEntity"/> related to a <see cref="UserEntity"/>
        /// </summary>
        /// <param name="userId">
        /// <see cref="UserEntity"/>'s ID
        /// </param>
        /// <returns>
        /// An <see cref="IEnumerable{T}"/> of <see cref="RoleEntity"/>. If no data is retrieved,
        /// returns an empty <see cref="IEnumerable{T}"/>
        /// </returns>
        /// <exception cref="ArgumentNullException"></exception>
        public IEnumerable<RoleEntity> GetUserRoles(string userId)
        {
            if (string.IsNullOrEmpty(userId))
            {
                throw new ArgumentNullException(nameof(userId));
            }

            Command command = new Command("spGetUserRoles", true);

            command.AddParameter("userId", userId);

            return _connection.ExecuteReader(command, role => _mapper.Map<RoleEntity>(role));
        }

        /// <summary>
        /// Remove a <see cref="RoleEntity"/> from <see cref="UserEntity"/>
        /// </summary>
        /// <param name="id">
        /// <see cref="RoleEntity"/>'s ID
        /// </param>
        /// <param name="userId">
        /// <see cref="UserEntity"/>'s ID
        /// </param>
        /// <returns>
        /// <c>true</c> If the role was successfully removed from the user. <c>false</c> Otherwise
        /// </returns>
        /// <exception cref="ArgumentNullException"></exception>
        public bool RemoveUser(string id, string userId)
        {
            if (string.IsNullOrEmpty(id))
            {
                throw new ArgumentNullException(nameof(id));
            }

            if (string.IsNullOrEmpty(userId))
            {
                throw new ArgumentNullException(nameof(userId));
            }

            Command command = new Command("spDeleteUserRole", true);

            command.AddParameter("roleId", id);
            command.AddParameter("userId", userId);

            return _connection.ExecuteNonQuery(command) > 0;
        }

        /// <inheritdoc/>
        /// <exception cref="ArgumentNullException"></exception>
        public bool Update(RoleEntity entity)
        {
            if (entity is null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            Command command = new Command("spUpdateRole", true);

            command.AddParameter("id", entity.Id);
            command.AddParameter("name", entity.Name);

            return _connection.ExecuteNonQuery(command) > 0;
        }
    }
}
