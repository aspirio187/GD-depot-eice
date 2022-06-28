using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.DepotEice.DAL.Entities
{
    public class RoleEntity
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public RoleEntity(string id, string name)
        {
            Id = id ??
                throw new ArgumentNullException(nameof(id));

            Name = name ??
                throw new ArgumentNullException(nameof(name));
        }
    }
}
