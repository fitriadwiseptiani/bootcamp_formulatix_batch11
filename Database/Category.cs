using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Database;

public class Category
{
	// CategoryId = primarykey
	[Key]
	public int CategoryId { get; set; }

	[Required]
	[StringLength(15)]
	public string CategoryName { get; set; } = null!;

	[Column(TypeName = "ntext")]
	public string? Description { get; set; }
	public virtual ICollection<Product> Products { get; set; }

	public Category()
	{
		Products = new HashSet<Product>();
	}
}
