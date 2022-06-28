using DepotEice.Shared.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.DepotEice.DAL.Entities
{
    /// <summary>
    /// Represent the UserToken table in the database
    /// </summary>
    public class UserToken
    {
        public string Id { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }
        public DateTime DeliveryDateTime { get; set; }
        public DateTime ExpirationDateTime { get; set; }

        /// <summary>
        /// Create an instance of <see cref="UserToken"/> object
        /// </summary>
        /// <param name="id">User</param>
        /// <param name="type"></param>
        /// <param name="value"></param>
        /// <param name="deliveryDateTime"></param>
        /// <param name="expirationDateTime"></param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="DateTimeOutOfRangeException"></exception>
        public UserToken(string id, string type, string value, DateTime deliveryDateTime,
            DateTime expirationDateTime)
        {
            Id = id ??
                throw new ArgumentNullException(nameof(id));

            Type = type ??
                throw new ArgumentNullException(nameof(type));

            Value = value ??
                throw new ArgumentNullException(nameof(value));

            DeliveryDateTime = (deliveryDateTime < DateTime.Now)
                ? deliveryDateTime
                : throw new DateTimeOutOfRangeException(nameof(deliveryDateTime));

            ExpirationDateTime = (expirationDateTime > deliveryDateTime)
                ? expirationDateTime
                : throw new DateTimeOutOfRangeException(nameof(expirationDateTime));
        }
    }
}
