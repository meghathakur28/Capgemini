using System;
using System.Collections.Generic;
using System.Text;

namespace AuthenticationState
{
    public class ApplicationAuthState
    {
        private List<IUser> RegisteredUsers = null;
        private List<IUser> UsersLoggedIn = null;
        private List<string> AllowedLocations = null;
        public ApplicationAuthState(List<string> allowedlocation) 
        {
            this.RegisteredUsers = new List<IUser>();
            this.UsersLoggedIn = new List<IUser>();
            this.AllowedLocations = allowedlocation;
        }
        public string Register(IUser user)
        {
            bool flag = true;
            IUser userfound = RegisteredUsers.Find(u => u.Email == user.Email);
            if(userfound != null)
            {
                flag = false;
                return "User already registered.";
            }
            RegisteredUsers.Add(user);
            return "User registered successfully.";

        }
        public string Login(IUser user)
        {
            bool flag = true;
            IUser userfound = RegisteredUsers.Find(u => u.Email == user.Email);
            if(userfound == null)
            {
                flag = false;
                return "User not registered.";
            }
            if(user.IncorrectAttempt>3)
            {
                flag = false;
                return "Account locked due to multiple incorrect attempts.";
            }
            if(userfound.Password != user.Password)
            {
                flag = false;
                userfound.IncorrectAttempt += 1;
                return "Incorrect password.";
            }
            if(!AllowedLocations.Contains(user.Location))
            {
                flag = false;
                return "Login from this location is not allowed.";
            }
            UsersLoggedIn.Add(userfound);
            userfound.IncorrectAttempt = 0;
            return "User logged in successfully.";
        }
        public string Logout(IUser user)
        {
           IUser userFound = UsersLoggedIn.Find(u => u.Email == user.Email);
            if(userFound == null)
            {
                return "User is not logged in.";
            }
            UsersLoggedIn.Remove(userFound);
            return "User logged out successfully.";
        }
    }
}
