//Vi laver to objekter ud fra vores klasser
Item Im = new Item("genstand", 466);
FoodItem FIm = new FoodItem("what", 54, 45);
NonFoodItem NIm = new NonFoodItem("cykel", 3000, ["Skumgummi", "metal", "carbonfiber"]);


Console.WriteLine(FIm.ToString());
Console.WriteLine(NIm.ToString());