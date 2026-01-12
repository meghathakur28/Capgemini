using System;
using System.Collections.Generic;
using System.Text;

namespace AuthenticationState
{
    public class User:IUser
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Location { get; set; }
        public int IncorrectAttempt { get; set; }
        public User(int id,string email,string password, string location)
        {
            this.Id = id;
            this.Email = email;
            this.Password = password;
            this.Location = location;
            this.IncorrectAttempt = 0;
        }

    }
}
