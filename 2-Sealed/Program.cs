class Zoo
{
	
}
//tidak mengizinkan dari class manapun menjadi childnya dan menjadikan class ini sebagai parent
// akan tetapi dia bisa menjadi child dari suatu parent
sealed class Animal : Zoo	
{
	
}
class Monkey : Animal  //tidak bisa inheritance karena class Animal tidak mengizinkan(sealed)
{
	
}
