using System;
using System.Collections.Generic;

namespace CodeQLAlertTrigger
{
    public class DataAccess
    {
        private Dictionary<string,string> _users = new Dictionary<string, string>();
        private const string SqlConnectionString = "Server=localhost;Database=SecurityDb;User Id=generaluser;Password=somepassword;";

        public DataAccess()
        {
            _users.Add("user1","password1");
            _users.Add("user2","password2");
            _users.Add("user3","password3");
            _users.Add("user4","password4");
        }

        public bool IsValidUser(string username, string password)
        {
            // Should access the database but we wont
            if (!_users.ContainsKey(username))
            {
                return false;
            }

            return _users[username] == password;
        }
    }
}