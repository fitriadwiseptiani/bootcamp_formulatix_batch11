using _6_ContohPubsandSubs;

class Program {
	static void Main() 
	{
		ShopeeCreator shopeecreator = new();
		// harus selalu menambah lagi kalau ada subscriber atau metode baru
		Follower follower = new();
		Popup popup = new();
		Email email = new();
		Sms sms = new();
		WhatsApp whatsApp= new();
		
		// mendefinisikan secara terus menerus
		Follower follower2 = new(); 
		
		shopeecreator.follower = follower;
		shopeecreator.popup = popup;
		shopeecreator.email = email;
		shopeecreator.sms = sms;
		shopeecreator.whatsApp = whatsApp;
		// shopeecreator.follower2 = follower2;
		 
		shopeecreator.UploadVideo();
	}
}