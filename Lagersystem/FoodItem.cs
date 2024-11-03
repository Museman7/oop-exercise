//Vi nedarver alle værdier fra klassen Item (vores superklasse/base class/parent)...
//...i vores nye klasse FoodItem (vores subklasse/child)
public class FoodItem : Item
{
	//Tilføjer en ny værdi som er en dato
	double DateTime = 4;
	
	public double GetDate()
	{
		return DateTime;
	}
	
	//Vi laver et konstruktor ud fra FoodItem klassen...
	//...Semikolon betyder vi henter værdier fra vores base class som er item
	public FoodItem(string name, double price, double DateTime) : base(name, price)
	{
		this.DateTime = DateTime;
	}
	
	public override string ToString()
	{
		return "FoodItem name= '" + GetName() + "'"
					+ " price= '" + GetPrice() + "'"
					+ " expiresAt= '" + GetDate() + "' days.";
	}
}