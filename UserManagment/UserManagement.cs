using OrganizerApp.Entities;
using System.Linq;

namespace OrganizerApp.UserMenagment
{
    public class UserManagement
    {
        public bool IsAccountExist(string Email, string Password)
        {
            using (var db = new OrganizerDbContext())
            {
                var userValue = db.User.FirstOrDefault(x => x.Email == Email && x.Password == Password);

                if (userValue != null)
                {
                    return true;
                }

            }

            return false;
        }

        public bool IsAccountExist(string Email)
        {
            using (var db = new OrganizerDbContext())
            {
                var userValue = db.User.FirstOrDefault(x => x.Email == Email);

                if (userValue != null)
                {
                    return true;
                }
            }

            return false;
        }

        public void registerAccount(string username, string email, string password)
        {
            using (var db = new OrganizerDbContext())
            {

                var newUser = new User
                {
                    Name = username,
                    Email = email,
                    Password = password
                };

                db.Add(newUser);
                db.SaveChanges();
            }
        }


    }
}
