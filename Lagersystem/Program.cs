//Vi laver objekter ud fra vores klasser og 
Item Im = new Item("genstand", 466);
FoodItem FIm = new FoodItem("what", 54, 45);
NonFoodItem NIm = new NonFoodItem("cykel", 3000, ["Skumgummi", "Plastic", "carbonfiber"]);

NonFoodItem NIm2 = new NonFoodItem("Bil", 20000, ["Aluminium", "Elektronik", "Gummi", "Læder"]);



Console.WriteLine(FIm.ToString());
Console.WriteLine(NIm.ToString());
Console.WriteLine(NIm2.ToString());
Console.WriteLine(NIm.name);