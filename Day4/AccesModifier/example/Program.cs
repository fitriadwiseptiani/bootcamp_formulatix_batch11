class Engine
{
	private void Run()
	{
		Console.Writeline("Engine Run");
	}
}
class ElectricEngine : Engine
 
 {
 	public void Off()
	{
		Console.WriteLine("Engine Off");
	}
 }
 class Program 
 {
 	Engine engine = new Engine();
	engine.Run();
	engine.Off();
	
	ElectricEngine ee = new ElectricEngine();
	ee.Run();
	ee.Off();
 }