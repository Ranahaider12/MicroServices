using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserMicroservices.Model;

namespace UserMicroservices.Repo
{
    public interface IUser
    {
        List<UserList>  GetUSers();
    }
}
