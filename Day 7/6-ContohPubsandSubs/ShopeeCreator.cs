namespace _6_ContohPubsandSubs;

public class ShopeeCreator
{
	public Follower follower;
	public Email email;
	public Popup popup;
	public Sms sms;
	public WhatsApp whatsApp;
	
	public void UploadVideo()
	{
		Console.WriteLine("Seorang penjual sedang upload video ...");
		SentNotification("Koleksi baju terbaru ...");
	}
	
	public void SentNotification(string notif)
	{
		follower.ShowVideo(notif);
		email.Showtext(notif);
		popup.Showtext(notif);
		sms.ShowText(notif);
	}
}
