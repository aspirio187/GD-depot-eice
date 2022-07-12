using API.DepotEice.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.DepotEice.DAL.IRepositories
{
    public interface IAppointmentRepository : IRepositoryBase<AppointmentEntity, int>
    {
        /// <summary>
        /// Set the <see cref="AppointmentEntity.Accepted"/> column's value to <c>true</c> in the 
        /// database
        /// </summary>
        /// <param name="appointmentId">
        /// <see cref="AppointmentEntity.Id"/>'s value
        /// </param>
        /// <returns>
        /// <c>true</c> If at least one row was affected in the database. <c>false</c> Otherwise
        /// </returns>
        bool AcceptAppointment(int appointmentId);
    }
}
