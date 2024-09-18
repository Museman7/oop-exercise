// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Seconds passed since 1970, january 1st. Unix epoch time
int seconds = 1726531205;
//Amount of seconds in one year
int OneYear = 31556926;
//Amount of seconds in one day
int OneDay = 86400;


int years = seconds / OneYear;
int rest = seconds % OneYear;
int days = rest / OneDay;

Console.WriteLine("It's been " + years + " years");
Console.WriteLine("It's been " + days + " days");
Console.WriteLine(rest);
