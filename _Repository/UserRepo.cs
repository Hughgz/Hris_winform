using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using HRMngt.Model;

namespace HRMngt._Repository
{
    public class UserRepo : BaseRepo, IUserRepository
    {

        public UserRepo(string connectionString) { 
            this.connectionString = connectionString;
        }
        public void Add(Users user)
        {
            throw new NotImplementedException();
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public void Edit(Users user)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Users> FindAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Users> GetAll()
        {
            var userList = new List<Users>();
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand())
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT userID, name, on_boarding, position, status FROM users ORDER BY userID desc";
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var user = new Users();
                        user.Name = reader[1].ToString();
                        user.On_boarding = reader[2].ToString();
                        user.UserID = reader[3].ToString();
                        user.Position = reader[4].ToString();
                        user.Status = reader[5].ToString();
                        userList.Add(user);
                    }
                }
            }
            return userList;
        }
    }
}
