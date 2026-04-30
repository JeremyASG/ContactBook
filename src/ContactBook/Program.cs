namespace ContactBook;

public class Program
{
	public static void Main()
	{
		Contact c1 = new Contact();
        Contact c2 = new Contact("Jane", "Smith", "0987654321");
        Contact c3 = new Contact("John", "Doe", "1234567890", "john.doe@example.com");
	}
}