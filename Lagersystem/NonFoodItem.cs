public class NonFoodItem : Item
{	
	string[] materials;
		
	public string GetMaterial()
	{
		string m = "[";
		for (int i = 0; i < materials.Length; i++)
		{
			m += (i == 0 ? "" : ", ") + materials[i];
		}
		m += "]";
		return m;
	}
	
	public NonFoodItem(string name, double price, string[] materialsValue) : base(name, price)
	{
		materials = materialsValue;
	}
	
	public override string ToString()
	{
		return "NonFoodItem name '" + GetName() + "' price='" + GetPrice() + "' materials='" + GetMaterial() + "'";
	}
}

