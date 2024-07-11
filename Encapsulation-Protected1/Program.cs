class Engine {
 protected string engineType;
 public void SetEngine(string type) {
  engineType = type;
 }
 public string CheckEngine() {
	  return engineType;
 }
}
class ElectricEngine : Engine {
}
class Program {
 static void Main() {
  Engine engine = new Engine();
  engine.SetEngine("toyota"); //error
  Console.WriteLine(engine.CheckEngine()); //error
  
  ElectricEngine ee = new ElectricEngine();
  ee.SetEngine("tesla"); //error
  Console.WriteLine(ee.CheckEngine());
 }
}
// line 15 error karena fungsi yang dibuat bersifat private
// line 16 error karena fungsi yang dibuat tidak ada pada class Engine
// line 19 error karena fungsi setEngine() bersifat private
