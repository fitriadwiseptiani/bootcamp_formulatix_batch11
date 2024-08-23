
using log4net;
using log4net.Config;

class Program
{
	static void Main()
	{
		ILog logger = LogManager.GetLogger(typeof(Robot));
		XmlConfigurator.Configure(new FileInfo("log4net.config"));
		Robot robot = new Robot(logger);
		robot.MoveRight();
		robot.MoveLeft();
		robot.TurnOff();
	}
}
class Robot
{
	private ILog _log;
	public Robot(ILog log)
	{
		_log = log;
	}
	public void MoveLeft()
	{
		_log.Info("Robot move left executed");
		Console.WriteLine("Robot will move ...");
		Console.WriteLine("Move Left finished");
	}

	public void MoveRight()
	{
		_log.Debug("robot move right executed");
		Console.WriteLine("Robot will move ...");
		Console.WriteLine("Move Right finished");	}

	public void TurnOff()
	{
		_log.Info("Robot turn off executed");
		Console.WriteLine("Robot will turn off ...");
		Console.WriteLine("Turn off finished");	}
}