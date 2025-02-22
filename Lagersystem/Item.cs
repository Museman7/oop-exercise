//Navnet på klassen
public class Item
{
	public string name;
	double price;
	
	public string GetName()
	{
		return name;
	}
	public double GetPrice()
	{
		return price;
	}
	
	//Genererer et konstruktor ud fra klassen item, med alle værdierne vi har før
	public Item(string nameInput, double priceInput)
 	{
 		this.name = nameInput;
 		this.price = priceInput;
 	}
 }