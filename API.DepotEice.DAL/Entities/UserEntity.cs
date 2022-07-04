using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.DepotEice.DAL.Entities
{
    /// <summary>
    /// Represent the <c>Users</c> table in the database
    /// </summary>
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
            if (string.IsNullOrEmpty(id))
            {
                throw new ArgumentNullException(nameof(id));
            }

            if (string.IsNullOrEmpty(email))
            {
                throw new ArgumentNullException(nameof(email));
            }

            if (string.IsNullOrEmpty(normalizedEmail))
            {
                throw new ArgumentNullException(nameof(normalizedEmail));
            }

            if (string.IsNullOrEmpty(passwordHash))
            {
                throw new ArgumentNullException(nameof(passwordHash));
            }

            if (string.IsNullOrEmpty(firstName))
            {
                throw new ArgumentNullException(nameof(firstName));
            }

            if (string.IsNullOrEmpty(lastName))
            {
                throw new ArgumentNullException(nameof(lastName));
            }

            DateTime now = DateTime.Now;

            if (birthDate > new DateOnly(now.Year, now.Month, now.Day))
            {
                throw new ArgumentOutOfRangeException(nameof(birthDate));
            }

            if (string.IsNullOrEmpty(concurrencyStamp))
            {
                throw new ArgumentNullException(nameof(concurrencyStamp));
            }

            if (string.IsNullOrEmpty(securityStamp))
            {
                throw new ArgumentNullException(nameof(securityStamp));
            }

            Id = id;
            Email = email;
            NormalizedEmail = normalizedEmail;
            PasswordHash = passwordHash;
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            ConcurrencyStamp = concurrencyStamp;
            SecurityStamp = securityStamp;
            IsActive = isActive;
        }

        public UserEntity(string email, string firstName, string lastName, DateOnly birthDate)
        {
            if (string.IsNullOrEmpty(email))
            {
                throw new ArgumentNullException(nameof(email));
            }

            if (string.IsNullOrEmpty(firstName))
            {
                throw new ArgumentNullException(nameof(firstName));
            }

            if (string.IsNullOrEmpty(lastName))
            {
                throw new ArgumentNullException(nameof(lastName));
            }

            DateTime now = DateTime.Now;

            if (birthDate > new DateOnly(now.Year, now.Month, now.Day))
            {
                throw new ArgumentOutOfRangeException(nameof(birthDate));
            }

            Id = Guid.NewGuid().ToString();
            Email = email;
            NormalizedEmail = email.ToUpper();
            // TODO : Hash password here or in the database ?
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            ConcurrencyStamp = Guid.NewGuid().ToString();
            SecurityStamp = Guid.NewGuid().ToString();
            IsActive = false;
        }
    }
}
