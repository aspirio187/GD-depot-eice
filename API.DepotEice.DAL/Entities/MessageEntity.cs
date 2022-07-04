using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.DepotEice.DAL.Entities
{
    /// <summary>
    /// Represent the <c>Messages</c> table in the database
    /// </summary>
    public class MessageEntity
    {
        /// <summary>
        /// <see cref="MessageEntity"/>'s ID in the database
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// <see cref="MessageEntity"/>'s content
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// ID of <see cref="UserEntity"/> sending the message
        /// </summary>
        public string UserFromId { get; set; }

        /// <summary>
        /// ID of <see cref="UserEntity"/> receving the message
        /// </summary>
        public string UserToId { get; set; }
        
        /// <summary>
        /// Instanciate an object <see cref="MessageEntity"/> and initialize all its properties
        /// </summary>
        /// <param name="id">Message's ID</param>
        /// <param name="body">The content of the message</param>
        /// <param name="userFromId">The ID of the user sending the message</param>
        /// <param name="userToId">The ID of the user receiving the message</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        public MessageEntity(int id, string body, string userFromId, string userToId)
        {
            if (id <= 0) throw new ArgumentOutOfRangeException(nameof(id));
            if (string.IsNullOrEmpty(body)) throw new ArgumentNullException(nameof(body));
            if (string.IsNullOrEmpty(userFromId)) throw new ArgumentNullException(nameof(userFromId));
            if (string.IsNullOrEmpty(userToId)) throw new ArgumentNullException(nameof(userToId));

            Id = id;
            Body = body;
            UserFromId = userFromId;
            UserToId = userToId;
        }

        /// <summary>
        /// Instanciate an object <see cref="MessageEntity"/> and initialize all its properties
        /// except the <see cref="Id"/>
        /// </summary>
        /// <param name="body">The content of the message</param>
        /// <param name="userFromId">The ID of the user sending the message</param>
        /// <param name="userToId">The ID of the user receiving the message</param>
        /// <exception cref="ArgumentNullException"></exception>
        public MessageEntity(string body, string userFromId, string userToId)
        {
            if (string.IsNullOrEmpty(body)) throw new ArgumentNullException(nameof(body));
            if (string.IsNullOrEmpty(userFromId)) throw new ArgumentNullException(nameof(userFromId));
            if (string.IsNullOrEmpty(userToId)) throw new ArgumentNullException(nameof(userToId));

            Id = 0;
            Body = body;
            UserFromId = userFromId;
            UserToId = userToId;
        }
    }
}
