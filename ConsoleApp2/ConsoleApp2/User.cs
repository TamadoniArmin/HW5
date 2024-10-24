using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class User
    {
        public string Username { get; set; };
        public string Password { get; set; };
        private bool Checkpassword { get; set; }
        private bool UserActive { get; set; } = true;
        private bool UserInactive { get; set; } = false;
        public bool Admin { get; private set; }
        protected bool Login { get; set; }
        public int NumberInArray { get; set; }
        public string Role { get; set; }
        public User(string username, string password, bool role)
        {
            Username = username;
            Password = password;
            Admin = role;
        }//counstructor
        /*public bool CheckInfo(string enteredusername, string enteredpass)
        {
            if (enteredusername==Username && enteredpass==Password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }*/
        public static void changePassword(User[] usres, string Modleusername)
        {
            string temp = "";
            foreach (var usre in usres)
            {
                if (usre is null) break;
                if (usre.Username == Modleusername)
                {
                    do
                    {
                        Console.Write("Please enter your old password: ");
                        temp = Console.ReadLine();
                        if (usre.Password == temp)
                        {
                            Console.Write("Please enter your new password: ");
                            usre.Password = Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("The password that you have entered is not correct! Please enter it correctly.");
                        }
                    } while (usre.Password != temp);
                }
            }
        }
        public static int Lastmember(User[] users)
        {
            int counter = 0;
            for (int i = 0; i < 100; i++)
            {
                if (users[i] == null)
                {
                    counter++;
                    break;
                }
                else
                {
                    counter++;
                }
            }
            return counter;
        }
        /*public void CheckRole(User[] usres, string Modleusrename)
        {
            for (int i = 0; i < 100; i++)
            {
                if ()
                {

                }
            }
        }*/
    }
}
