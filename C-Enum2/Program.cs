
class Program {
	static void Main() {
		// karena langsung diarahkan ke enumnya tidak bisa maka harus di unboxing dahulu sesuai tipe data yang dimaksud
		int result = (int) MonthOfYear.Feb;
		Console.WriteLine(result);	//2
		
		MonthOfYear result2 = (MonthOfYear)2;
		Console.WriteLine(result2); 	//Feb
		
		string x = MonthOfYear.Dec.ToString();
		Console.WriteLine(x);	//Dec
	}
}
public enum MonthOfYear {
	// Jan = 0,  //default dari 0 nilainya
	Jan = 1,	//bisa diganti seperti ini
	Feb,
	Mar,
	Apr,
	May,
	Jun,
	Jul,
	Aug,
	Sep,
	Oct,
	Nov,
	Dec
}