using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserMicroservices.Model;

namespace UserMicroservices.Repo
{
    public class UserRepo : IUser
    {
      
        public List<UserList> GetUSers()
        {
            var data = new List<UserList>();
            try
            {

                var data1 = new UserList
                {
                    City = "Lahore",
                    Status = "Active",
                    Name = "Haider",
                    Email = "haider@gmail.com"
                };
                data.Add(data1);
                var data2 = new UserList
                {
                    City = "Karachi",
                    Status = "Active",
                    Name = "Jhon",
                    Email = "jhon@gmail.com"
                };
                data.Add(data2);
                var data3 = new UserList
                {
                    City = "Delhi",
                    Status = "Active",
                    Name = "Hamza",
                    Email = "hamza@gmail.com"
                };
                data.Add(data3);
                var data4 = new UserList
                {
                    City = "Lahore",
                    Status = "Active",
                    Name = "Ali",
                    Email = "ali@gmail.com"
                };
                data.Add(data4);
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
            return data;
        }
    }
}
