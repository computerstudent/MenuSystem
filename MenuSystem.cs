public class MenuSystem 
{
	public List<Product> products = new List<Product>();
	
	public MenuSystem ()
	{
		
	}
	
	public AddProductToMenu (Product product)
	{
		products.Add(product);
	}
	
	public RemoveProductFromMenu (Product product)
	{
		products.Add(product);
	}	
}