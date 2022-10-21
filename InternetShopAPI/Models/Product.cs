namespace InternetShopAPI.Models;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Category Category { get; set; }
    public string Atribute { get; set; }
    public int Quantity { get; set; }
}