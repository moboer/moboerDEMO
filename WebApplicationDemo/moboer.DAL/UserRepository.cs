using moboer.IDAL;
using moboer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moboer.DAL
{
    class UserRepository:BaseRepository<User>, InterfaceUserRepository
    {
    }
}
