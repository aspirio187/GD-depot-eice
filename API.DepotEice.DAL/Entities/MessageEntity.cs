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
        public string SenderId { get; set; }

        /// <summary>
        /// ID of <see cref="UserEntity"/> receving the message
        /// </summary>
        public string ReceiverId { get; set; }

        /// <summary>
        /// Instanciate an object <see cref="MessageEntity"/> and initialize all its properties
        /// </summary>
        /// <param name="id">Message's ID</param>
        /// <param name="body">The content of the message</param>
        /// <param name="senderId">The ID of the user sending the message</param>
        /// <param name="receiverId">The ID of the user receiving the message</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        public MessageEntity(int id, string body, string senderId, string receiverId)
        {
            if (id <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(id));
            }

            if (string.IsNullOrEmpty(body))
            {
                throw new ArgumentNullException(nameof(body));
            }

            if (string.IsNullOrEmpty(senderId))
            {
                throw new ArgumentNullException(nameof(senderId));
            }

            if (string.IsNullOrEmpty(receiverId))
            {
                throw new ArgumentNullException(nameof(receiverId));
            }

            Id = id;
            Body = body;
            SenderId = senderId;
            ReceiverId = receiverId;
        }

        /// <summary>
        /// Instanciate an object <see cref="MessageEntity"/> and initialize all its properties
        /// except the <see cref="Id"/>
        /// </summary>
        /// <param name="body">The content of the message</param>
        /// <param name="senderId">The ID of the user sending the message</param>
        /// <param name="receiverId">The ID of the user receiving the message</param>
        /// <exception cref="ArgumentNullException"></exception>
        public MessageEntity(string body, string senderId, string receiverId)
        {
            if (string.IsNullOrEmpty(body))
            {
                throw new ArgumentNullException(nameof(body));
            }

            if (string.IsNullOrEmpty(senderId))
            {
                throw new ArgumentNullException(nameof(senderId));
            }

            if (string.IsNullOrEmpty(receiverId))
            {
                throw new ArgumentNullException(nameof(receiverId));
            }

            Id = 0;
            Body = body;
            SenderId = senderId;
            ReceiverId = receiverId;
        }
    }
}
