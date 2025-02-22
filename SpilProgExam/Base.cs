//Navnet på klassen
public class Base
{
	//Defines the event
	public event EventHandler OnCriticalHit;

	//Catches the event
	public void OnCritRoll(object sender, EventArgs e)
	{
		Console.WriteLine("Crit!");	
	}
	public void CriticalRoll()
	{
		Random rnd = new Random();
		//For loop, loops 6 times
		for (int i = 0; i < 6; i++)
		{
			//generates random number between 1 and 6
			int x = rnd.Next(1, 7);
			Console.WriteLine(x);
			if (x == 6)
			{
				//Fires off the event. Invoke ensures the event is only fired, if OnCriticalHit is not null
				OnCriticalHit?.Invoke(this, EventArgs.Empty);
			}
		}
	}
	
	
	private string name;
	public string GetName()
	{
		return name;
	}

	public int Addition (int i, int l)
	{
		return i+l;
	}

	public bool IsEven(int i)
	{
		if (i % 2 == 0)
		{
			return true;
		}
		else
		{
			return false;
		}
	}
	
	//en konstruktor der generer en instans af klassen
	public Base(string word)
	{
		this.name = word;
	}
}

