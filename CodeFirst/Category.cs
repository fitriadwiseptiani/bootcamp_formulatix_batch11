using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst;

public class Category
{
	public int CategoryId { get; set; }
	// [DefaultValue(15)]
	// [Column(TypeName = "nvarchar (15)")]
	public string CategoryName { get; set; }
	// [Column(TypeName = "'ntext'")]
	public string Description { get; set; }
	// [Column(TypeName = "'image'")]
	public string Picture { get; set; }
	public IEnumerable<Product> Products {get; set;}
	public Category()
	{
		Products = new HashSet<Product>();
	}
}	
