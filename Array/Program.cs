// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] myarray = [2, 1, 2, 5, 7, 6, 3, 10];

//skriver x'ne plads i array, start ved 0
//Console.WriteLine(myarray[x]);
//skriver længden på array, started ved 1
//Console.WriteLine(myarray.Length);

int highest = myarray[0];

//Så længe at i er mindre end størrelsen på vores array
for (int i = 0; i < myarray.Length; i++)
{
	//Hvis det nuværende array-nummer er større end det nuværende højeste
	if (myarray[i] > highest)
	{
		//Så er den nuværende array-nummer det største
		highest = myarray[i];
	}
	
	Console.WriteLine("nuværende array nummer: " + myarray[i] + " og de Højeste array nummer :" + highest);
}