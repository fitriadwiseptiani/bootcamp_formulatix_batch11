namespace _7_DelegatePubsAndSubs;

// dideklarasikan terlebih dahulu
public delegate void Followers(string notif);
public class ShopeeCreator
{
	public Followers followers;
	public void CreatorUpload()
	{
		Console.WriteLine("Proses Upload Video berjalan ...");
		SentNotification("Creator A yang Anda ikuti telah menggunggah video ...");
	}
	public void SentNotification(string title)
	
	{
		followers(title);
	}
}
