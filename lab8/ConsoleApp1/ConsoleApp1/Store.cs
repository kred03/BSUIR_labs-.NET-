public class Store
{
    private List<Product> lstProd;

    public Store()
    {
        lstProd = new List<Product>();
    }

    public void AddAbsDiscountProduct(string name, double price, double discount)
    {
        lstProd.Add(new Product(name, new AbsDiscount(price, discount)));
    }

    public void AddNoDiscountProduct(string name, double price)
    {
        lstProd.Add(new Product(name, new NoDiscount(price)));
    }

    public double GetTotalPrice()
    {
        double total = 0;
        foreach (var product in lstProd)
        {
            total += product.GetPrice();
        }
        return total;
    }
}