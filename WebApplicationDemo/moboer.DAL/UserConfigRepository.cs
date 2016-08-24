using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using moboer.Models;
using moboer.IDAL;

namespace moboer.DAL
{
    class UserConfigRepository:BaseRepository<UserConfig>,InterfaceUserConfigRepository
    {
    }
}
