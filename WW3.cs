//Situation 1
Console.WriteLine("Enter your name: ");
string name = Console.ReadLine();
Console.WriteLine("Your name is: " + name);

//Situation 2
Console.WriteLine("Think of a number: ");
int myNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Your numbers is: " + myNum);

//Situation 3
Console.WriteLine("What is your name?");
string username = Console.ReadLine();

Console.WriteLine("What grade are you on?");
int usergrade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("And what strand are you currently studying?");
string userstrand = Console.ReadLine();

Console.WriteLine("From what section?");
string usersection = Console.ReadLine();

Console.WriteLine("Hello, " + username + " from " + userstrand + "-" + usergrade + usersection);

//SItuation 4

// Incorrect variables
double number = 333.333;
bool mybool = false;
char name1 = 'A', name2 = 'B', name3 = 'C';
string dinosaur = "T - rex";


Console.WriteLine("Enter your name: ");
string myname = Console.ReadLine();

Console.WriteLine("What is your age: ");
int age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("How much do you weigh");
double weight = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Hi, I'am " + myname + " and i'm " + age + " and I weigh " + weight);