void Main() {
	int a = 1;
	int b = 2;
	Console.WriteLine( (a+b) == 3 ); //True
	
	float c = 0.1f;
	float d = 0.2f;
	Console.WriteLine( (c+d) == 0.3f); //True 
	
	double e = 0.1;
	double f = 0.2;
	Console.WriteLine( (e+f) );  //hasilnya 0.300000004 jadi tidak equal dengan 0.3. jadi kalau double harus pakai < atau >
	Console.WriteLine( (e+f) == 0.3 ); //false
	
	decimal g = 0.01M;
	decimal h = 0.02M;
	Console.WriteLine( (g+h) == 0.03M); //true  . presisi tinggi
}