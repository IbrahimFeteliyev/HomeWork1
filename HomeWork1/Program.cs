
using HomeWork1;

Product Product1 = new Product(1,"unnamed",1000);

Product1.ChangeName();
Console.WriteLine("Product ID: " + Product1.ID); 
Console.WriteLine("Product Name: " + Product1.Name);   
Console.WriteLine("Product Price: " + Product1.Price);
Console.Write("18% of product price : ");
Product1.PercentCalculator();



