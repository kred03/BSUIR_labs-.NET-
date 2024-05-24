public class Product
{
    public string Name { get; set; }
    private IPrice priceStrategy;

    public Product(string name, IPrice priceStrategy)
    {
        Name = name;
        this.priceStrategy = priceStrategy;
    }

    public double GetPrice()
    {
        return priceStrategy.GetPrice();
    }
}