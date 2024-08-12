namespace MyCalculator.Test;

public class MyCalculatorTest
{
	// buat variabel terlebih dahulu
	private Calculator _calculator;
	
	// setup untuk variabel yang telah dibuat
	[SetUp]
	public void SetUp()
	{
		_calculator = new Calculator();
	}
	[Test]
	public void Add_ReturnCorrectResult()
	{
		// Arrange
		int a = 3;
		int b = 2;
		int expected = 5;
		// Act
		int result = _calculator.Add(a, b);
		
		// Assert
		Assert.AreEqual(expected, result);
	}
	[TestCase(3,4,7)]
	[TestCase(2,4,6)]
	[TestCase(9,4,13)]
	// cara lain agar lebih mudah mengetes beberapa
	public void Add_ReturnCorrectResult(int a, int b, int expected)
	{
		// Arrange

		// Act
		int result = _calculator.Add(a, b);
		
		// Assert
		Assert.That(result, Is.EqualTo(expected));
	}
	public void Add_ReturnThrowExceptioan_AddingZero()
	{
		// Arrange
		int a = 0;
		int b = 0;
		// Act
		// Assert
		Assert.Throws<Exception>(()=>_calculator.Add(a, b));
	}
}