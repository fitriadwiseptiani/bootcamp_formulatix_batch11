namespace DatabaseFirst;

public class Product
{
	public int ProductId { get; set; }
	public string ProductName { get; set;}
	public int CategoryId { get; set; }
	public Category category{ get; set; }
	
}
