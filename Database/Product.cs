using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database;

public class Product
{
	[Key] // primary key
	public int ProductId { get; set; }

	[Required]
	[StringLength(40)]
	public string ProductName { get; set; } = null!; //Non nullable 

	[Column("UnitPrice", TypeName = "money")]
	public decimal? Cost { get; set; }

	[Column("UnitsInStock")]
	public short? Stock { get; set; }

	public bool Discontinued { get; set; }
	[ForeignKey("Location")]
	public int LocationId { get; set; }
	public virtual Location Location { get; set; } = null!;
	[ForeignKey("Category")]
	public int CategoryId { get; set; }
	public virtual Category Category { get; set; } = null! ;
}
