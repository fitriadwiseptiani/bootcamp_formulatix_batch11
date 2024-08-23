// class yang dimaksud harus ttd dengan Idosposable
// membuat disposable pattern dengan arahkan pada interface kemudian klik icon "lamp" > implement with dispose pattern

class MyClass : IDisposable
{
	private int[] myArray;
	private FileStream fs;
	// private OfficeStream officeStream;
	private bool disposedValue;

	protected virtual void Dispose(bool disposing)
	{
		if (!disposedValue)
		{
			if (disposing)
			{
				// TODO: dispose managed state (managed objects)
				myArray = null;
			}

			// TODO: free unmanaged resources (unmanaged objects) and override finalizer
			// TODO: set large fields to null
			fs.Dispose();
			// officeStream = null;
			disposedValue = true;
		}
	}

	// TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
	~MyClass()
	{
		// Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
		Dispose(disposing: false);
	}

	public void Dispose()
	{
		// Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}
}

class Program
{
	static void Main(string[] args)
	{
		MyClass myClass= new MyClass();
	}
}