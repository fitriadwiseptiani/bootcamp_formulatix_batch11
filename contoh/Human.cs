namespace contoh;

public class Human
{
private int NIK;
	public int CheckNIK(string password) {
		if(password == "Admin#1234") {
			return NIK;
		}
		return 0;
	}
	public void SetNIK(int NIKBaru) {
		if(!(NIKBaru < 0)) {
			NIK = NIKBaru;
		}
	}
}
