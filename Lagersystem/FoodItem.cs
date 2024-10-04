//Vi nedarver alle værdier fra klassen Item (vores superklasse/base class/parent)...
//...i vores nye klasse FoodItem (vores subklasse/child)
public class FoodItem : Item
{
	//Tilføjer en ny værdi som er en dato
	double date = 4;
	
	public double GetDate()
	{
		return date;
	}
	//Vi laver et konstruktor ud fra FoodItem klassen...
	//...Semikolon betyder vi henter værdier fra vores base class som er item
	public FoodItem(string name, double price, double date) : base(name, price)
	{
		this.date = date;
	}
}