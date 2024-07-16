using _7_DelegatePubsAndSubs;

class Program
{
	static void Main(string[] args)
	
	{
		ShopeeCreator shopeeCreator= new ShopeeCreator();
		
		// hanya perlu declare disini apabila ada data yang ditambah tanpa mengubah bagian SC
		Notification notification= new Notification();
		// misal email
		// whatsapp
		shopeeCreator.followers +=notification.ShowNotification;
		
		shopeeCreator.CreatorUpload();
		
		
	}
}
