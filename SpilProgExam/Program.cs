Base b = new Base("Test");

//Subscribes to the OnCriticalHit event
b.OnCriticalHit += b.OnCritRoll;
b.CriticalRoll();



/*
Console.WriteLine(b.GetName());

Console.WriteLine(b.Addition(1,2));
int age = 19;


if (age >= 18)
{
    Console.WriteLine("Access Granted");
}
else
{
    Console.WriteLine("Access Denied");
}

age >= 18 ? "Access Granted" : "Access Denied";

string gender = "female";

switch (gender)
{
    case "male":
        Console.WriteLine("Male");
        break;
    case "female":
        Console.WriteLine("Female");
        break;
    default:
        Console.WriteLine("Other");
        break;
}

if (gender == "male")
{
    Console.WriteLine("Male");
}
else if (gender == "female")
{
    Console.WriteLine("Female");
}
else
{
    Console.WriteLine("Other");
}

Console.WriteLine(!true); //Prints False
Console.WriteLine(!false); //Prints True


int number1 = 17;
int number2 = 20;

bool a = number1%2==0 & number2%2==0;
Console.WriteLine(a); //Prints true if both are even numbers


string input = "Julia123";
string password = "Christine654";
bool permission = false;

if (input == password)
{
    Console.WriteLine(permission = true);
}
else
{
    Console.WriteLine(permission = false);
}



int tal;
tal = 21;

public static int KonstantTal = 21;


char symbol = 'a';

String ord = "1 sammensætning";

int tal = 21;

long flereTal = 21000L;

float kommaTal = 21.555F;

double kommaTal2 = 21.5555555;

bool check = true;


string[] Students;

bool[] wins = new bool[6];

string[] Months = ["january", "february", "march", "april", "may", "june", "july", "august", "september", "october", "november", "december"];

int[,] dimensions = new int[2, 5];

string[,] twoGroups = {{"John", "Jean", "Jeremy"}, {"Paul", "Patrick", "patricia"}};

int[][] jags = new int[4][];


object[] data = [symbol, ord, tal, flereTal, kommaTal, kommaTal2, check];

//Console.WriteLine(data[3]);

for (int i = 0; i < data.Length; i++)
{
    Console.WriteLine(data[i]);
}



int i = 0;

while ( i < data.Length)
{
    Console.WriteLine(data[i]);
    i ++;
}

*/