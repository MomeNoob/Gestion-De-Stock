using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum UserType
{
    Admin,
    NormalUser
}

namespace Gestion_De_Stock
{
    class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public UserType UserType { get; set; }

        public User(string userName, string password,UserType userType)
        {
            UserName = userName;
            Password = password;
            UserType = userType;
        }

        //Checks if the user exists
        public bool IsValidUser(User user)
        {

            //TODO : checks the credentials against the database
            return true;
        }

        public void AddNewUser(User user)
        {
            //TODO : add a new user to the database
        }

        public void DeleteUser(User user)
        {
            //TODO : delete user from database
        }

        public void ModifyUser(User user, User newDetails)
        {
            user.UserType = newDetails.UserType;
            user.UserName = newDetails.UserName;
            user.Password = newDetails.Password;
            //TODO : apply changes to the database
        }
    }
}
