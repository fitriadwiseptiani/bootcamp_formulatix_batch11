// Error parentchild
class Component
{
	public string brand;
	
}
class Bell : Component 
{
	public int size;
	// terjadi error karena persyaratan dari Parent
	public Bell(int size)
	{
		this.size = size;
	}
} 