using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.DepotEice.DAL.Entities
{
    public class UserEntity
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string NormalizedEmail { get; set; }
        public string PasswordHash { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly BirthDate { get; set; }
        public string ConcurrencyStamp { get; set; }
        public string SecurityStamp { get; set; }
        public bool IsActive { get; set; }

        public UserEntity(string id, string email, string normalizedEmail, string passwordHash,
            string firstName, string lastName, DateOnly birthDate, string concurrencyStamp,
            string securityStamp, bool isActive)
        {
            Id = id ??
                throw new ArgumentNullException(nameof(id));

            Email = email ??
                throw new ArgumentNullException(nameof(email));

            NormalizedEmail = normalizedEmail ??
                throw new ArgumentNullException(nameof(normalizedEmail));

            PasswordHash = passwordHash ??
                throw new ArgumentNullException(nameof(passwordHash));

            FirstName = firstName ??
                throw new ArgumentNullException(nameof(firstName));

            LastName = lastName ??
                throw new ArgumentNullException(nameof(lastName));

            BirthDate = (birthDate < new DateOnly(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day))
                ? birthDate
                : throw new ArgumentOutOfRangeException(nameof(birthDate));

            ConcurrencyStamp = concurrencyStamp ??
                throw new ArgumentNullException(nameof(concurrencyStamp));

            SecurityStamp = securityStamp ??
                throw new ArgumentNullException(nameof(securityStamp));

            IsActive = isActive;
        }
    }
}
