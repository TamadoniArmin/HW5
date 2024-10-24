using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class UserService
    {
        public User?[] Users { get; set; } = new User[100];
        public bool CheckLogin(string username, string password)
        {
            foreach (var user in Users)
            {
                if (user is null) break;
                else
                if (user.Username == username && user.Password == password)
                {
                    return true;
                }
            }
            return false;
        }
        public bool CheckAccess(string usrename)
        {
            foreach (var user in Users)
            {
                if (user is not null)
                {
                    if (user.Username == usrename && user.Admin == true)
                    {
                        return true;
                    }
                } 
            }
            return false;//در اینجا وقتی ریترن قبلی اجرا شود سراغ این نمیاد
        }
        public string Role(string Modleusername)//<--------------
        {
            foreach (var item in Users)
            {
                if (item is null) break;
                if (item.Username == Modleusername && item.Admin == true)
                {
                    return "Admin";
                }
            }
            return "Normal User";
        }
        public void ShowUsers(string Modleusername)
        {
            foreach (var user in Users)
            {
                if (user is null) break;
                if (user.Username == Modleusername && user.Admin == true)
                {
                    foreach (var item in Users)
                    {
                        if (item.Admin == true)
                        {
                            Console.WriteLine($"name: {item.Username} / role: Admin");
                        }
                        else
                        {
                            Console.WriteLine($"name: {item.Username} / role: Normal User");
                        }
                    }
                }
            }
        }

        public void AddUser()
        {
            string NewUsername = "";
            string Newpassword = "";
            char Role = '\0';
            int StartFrom = User.Lastmember(Users);
            char Wanttoaddmore = '\0';
            do
            {
                Console.WriteLine("Please enter new user's username");
                NewUsername = Console.ReadLine();
                Console.WriteLine("Please enter new user's password:");
                Newpassword = Console.ReadLine();
                Console.WriteLine("Is this users, Admin or not (+/-) ? ");
                Role = Convert.ToChar(Console.ReadLine());
                if (Role == '+')
                {
                    Users[StartFrom].Username = NewUsername;
                    Users[StartFrom].Password = Newpassword;
                    Users[StartFrom].Role = "Admin";
                }
                else
                {
                    Users[StartFrom].Username = NewUsername;
                    Users[StartFrom].Password = Newpassword;
                    Users[StartFrom].Role = "Normal User";
                }
                Console.WriteLine("Do you want to Add another user (+/-) ?");
                Wanttoaddmore = Convert.ToChar(Console.ReadLine());
                if (Wanttoaddmore == '-')
                {
                    break;
                }
                else
                {
                    StartFrom++;
                }

            } while (Wanttoaddmore == '+');
        }
        /*public void CheckRole(User[] usres, string Modleusrename)
        {
            for (int i = 0; i < 100; i++)
            {
                if ()
                {

                }
            }
        }
        */
    }
}
