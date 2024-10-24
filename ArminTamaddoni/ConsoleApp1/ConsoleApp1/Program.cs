using ConsoleApp1;
using System.Collections.Concurrent;
User[] usre1 = new User[100];
usre1[0] = new User("mehdi", "12345") { Admin = true };
usre1[1] = new User("Ali", "Ali1234") { Admin = false };
usre1[2] = new User("nazanin", "nazy1981") { Admin = false };
usre1[3] = new User("Amir", "Armiiiirrrrr") { Admin = false };
usre1[4] = new User("Armin", "Armineee") { Admin = false };
string enteredUsername = "";
string enteredpassword = "";
UserService userService = new UserService(usre1);
int choosenoption = 0;
char countinuework = '\0';
do
{
    Console.Write("Please enter your usrename: ");
    enteredUsername = Console.ReadLine()!;
    Console.Write("Please enter your password: ");
    enteredpassword = Console.ReadLine()!;
    if (userService.CheckLogin(enteredUsername, enteredpassword) == true)
    {
        Console.WriteLine("Wellcome");
        break;
    }
    Console.WriteLine("Username or Password that you have enterd is not correct! please enter it correctly.");
} while (userService.CheckLogin(enteredUsername, enteredpassword) == false);
if (userService.CheckAccess(enteredUsername))
{
    do
    {
        Console.Clear();
        Console.WriteLine("Please choose one of the options below: ");
        Console.WriteLine("1. If you want to change your password.");
        Console.WriteLine("2. If you want to see your role.");
        Console.WriteLine("3. If you want to see all users.");
        Console.WriteLine("4. If you want to add users.");
        //Console.WriteLine("5. If you want to logout.");
        choosenoption = int.Parse(Console.ReadLine())!;
        switch (choosenoption)
        {
            case 1:
                if (choosenoption == 1)
                {
                    User.changePassword(usre1, enteredUsername);
                };
                break;
            case 2:
                if (choosenoption == 2)
                {
                    userService.Role(enteredUsername);
                    string Roleofuser = userService.Role(enteredUsername);
                    Console.WriteLine(Roleofuser);
                };
                break;
            case 3:
                if (choosenoption == 3)
                {
                    userService.ShowUsers(enteredUsername);
                };
                break;
            case 4:
                if (choosenoption == 4)
                {
                    userService.AddUser();
                };
                break;
            case 5:
                if (choosenoption == 5)
                {
                    Console.WriteLine("***** (Good Bye) *****");
                };
                break;
            default:
                break;
        }
        Console.Write("Do you want to do somthing else (+/-) ? ");
        countinuework = Convert.ToChar(Console.ReadLine());
        if (countinuework=='-')
        {
            break;
        }
    } while (countinuework=='+'); 
}
else
    if (!userService.CheckAccess(enteredUsername))
{
    do
    {
        Console.Clear();
        Console.WriteLine("Please choose one of the options below: ");
        Console.WriteLine("1. If you want to change your password.");
        Console.WriteLine("2. If you want to see your role.");
        //Console.WriteLine("3. If you want to logout.");
        choosenoption = int.Parse(Console.ReadLine())!;
        switch (choosenoption)
        {
            case 1:
                if (choosenoption == 1)
                {
                    User.changePassword(usre1, enteredUsername);
                };
                break;
            case 2:
                if (choosenoption == 2)
                {
                    userService.Role(enteredUsername);
                    string Roleofuser = userService.Role(enteredUsername);
                    Console.WriteLine(Roleofuser);
                };
                break;
            default:
                break;
        }
        Console.Write("Do you want to do somthing else (+/-) ? ");
        countinuework = Convert.ToChar(Console.ReadLine()!);
        if (countinuework == '-')
        {
            break;
        }
    } while (countinuework == '+');
}
Console.Clear();
Console.WriteLine("***** (Good Bye) *****");

/*bool ResulInfo = false;
string Username = "";
string Password = "";*/
/*do
{
    Console.Write("Please enter your Usrename: ");
    Username = Console.ReadLine();
    Console.Write("Please enter your Password: ");
    Password = Console.ReadLine();
    ResulInfo = usre1.CheckInfo(Username, Password);
    if (ResulInfo == true)
    {
        break;
    }
    else
    {
        Console.WriteLine("The information that you have entered is not correct! Please enter it correctly.");
    }
}
while (ResulInfo == false);
switch(usre1)*/