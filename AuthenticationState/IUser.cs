using System;
using System.Collections.Generic;
using System.Text;

namespace AuthenticationState
{
    public interface IUser
    {
        int Id { get; set; }
        string Email { get; set; }
        string Password { get; set; }
        string Location { get; set; }
        int IncorrectAttempt { get; set; }
    }
}
