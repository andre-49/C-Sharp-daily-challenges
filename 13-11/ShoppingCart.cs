
public class ShoppingCart
{
    private readonly List<decimal> _prices = new();

    public void AddItem(decimal price)
    {
        _prices.Add(price);
    }    

    public decimal GetTotal()
    {
        return _prices.Sum();
    }

    public int GetItemCount()
    {
        return _prices.Count();
    }
}