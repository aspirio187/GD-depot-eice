using DepotEice.Shared.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.DepotEice.DAL.Entities
{
    /// <summary>
    /// Entity describing the <c>Appointments</c> table in the database
    /// </summary>
    public class AppointmentEntity
    {
        /// <summary>
        /// Appointment ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Appointment start date and time (hh:mm)
        /// </summary>
        public DateTime StartsAt { get; set; }

        /// <summary>
        /// Appointment end date and time (hh:mm)
        /// </summary>
        public DateTime EndsAt { get; set; }

        /// <summary>
        /// Appointment acceptance status <c>true = Accepted</c> <c>false = Not accepted</c>
        /// </summary>
        public bool Accepted { get; set; }

        /// <summary>
        /// Appointment linked user's ID
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// Instanciate an object <see cref="AppointmentEntity"/> and initialize all properties
        /// </summary>
        /// <param name="id">Appointment ID</param>
        /// <param name="startsAt">Date and time at which starts the appointment</param>
        /// <param name="endsAt">Date and time at which ends the appointment</param>
        /// <param name="accepted">Appointment acceptance flag</param>
        /// <param name="userId">Linked user's ID</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <exception cref="DateTimeOutOfRangeException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        public AppointmentEntity(int id, DateTime startsAt, DateTime endsAt, bool accepted,
            string userId)
        {
            if (id <= 0) throw new ArgumentOutOfRangeException(nameof(id));
            if (startsAt >= endsAt) throw new DateTimeOutOfRangeException(nameof(startsAt));
            if (string.IsNullOrEmpty(userId)) throw new ArgumentNullException(nameof(userId));

            Id = id;
            StartsAt = startsAt;
            EndsAt = endsAt;
            Accepted = accepted;
            UserId = userId;
        }

        /// <summary>
        /// Instanciate an object <see cref="AppointmentEntity"/> for a creation 
        /// <see cref="Id"/>
        /// </summary>
        /// <param name="startsAt">Date and time at which starts the appointment</param>
        /// <param name="endsAt">Date and time at which ends the appointment</param>
        /// <param name="userId">Linked user's ID</param>
        /// <exception cref="DateTimeOutOfRangeException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        public AppointmentEntity(DateTime startsAt, DateTime endsAt, string userId)
        {
            if (startsAt >= endsAt)
            {
                throw new DateTimeOutOfRangeException(nameof(startsAt));
            }

            if (string.IsNullOrEmpty(userId))
            {
                throw new ArgumentNullException(nameof(userId));
            }

            Id = 0;
            StartsAt = startsAt;
            EndsAt = endsAt;
            UserId = userId;
        }
    }
}
