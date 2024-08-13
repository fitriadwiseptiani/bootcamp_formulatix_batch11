using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst;

public class Product
{
	public int ProductId { get; set; }
	// [Column(TypeName = "nvarchar (40)")]
	public string ProductName { get; set;}
	// [Column(TypeName = "'int'")]
	public int CategoryId { get; set; }
	public Category category{ get; set; }
	// [Column(TypeName ="nvarchar(20)")]
	public string QuantityPerUnit { get; set; }
	// [Column(TypeName = "money")]
	public int UnitPrice{ get; set; }
	// [Column(TypeName =	"smallint")]
	public int UnitInStock { get; set; }
	// [Column(TypeName =	"smallint")]
	public int UnitOnorder { get; set; }
	// [Column(TypeName =	"smallint")]
	public int ReorderLevel { get; set; }
	// [Column(TypeName =	"bit")]
	// public bool Discontinued { get; set; }
}
