namespace store.Models;

public class Product
{
    public Product(int id=0, string name="default", double price=0.0d)
    {
        Id = id;
        Name = name;
        Price = price;
        
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    

}