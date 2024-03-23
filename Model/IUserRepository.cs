using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMngt.Model
{
    public interface IUserRepository
    {
        void Add(Users user);
        void Edit(Users user);
        void Delete(string id);
        IEnumerable<Users> GetAll();
        IEnumerable<Users> FindAll(); //searchs
    }
}
