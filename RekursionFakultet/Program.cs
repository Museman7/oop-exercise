// See https://aka.ms/new-console-template for more information

//lav en metode som har sin egen metode inde i sig selv for at finde fakultet


//int fak (int val1)
//
//{
//	val1 = val1 * 2;
//	return(val1);
//}
//
//Console.Write(fak(value));

int fak (int x)
{
	if (x > 0)
	{
		//Vi ganger x med metoden(-x) og looper indtil vi rammer 0
		x = x*fak(x-1);
		Console.WriteLine(x);
		
		return x;
	}
	else
	{
		return 1;
	}
}

Console.Write(fak());