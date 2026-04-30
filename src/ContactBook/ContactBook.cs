namespace ContactBook;

using System;


public class ContactBook
{
	public const string YES = "Y";
	public const string NO = "N";

	public readonly string[] YES_NO = new string[] { YES, NO };

	public const string NEXT_PAGE = "+";
	public const string PREV_PAGE = "-";
	public const string GOTO_PAGE = "G";
	public const string PAGE_SIZE = "S";
	public const string CREATE_CONTACT = "C";
	public const string REVIEW_CONTACT = "R";
	public const string UPDATE_CONTACT = "U";
	public const string DELETE_CONTACT = "D";
	public const string FIND_CONTACTS = "F";
	public const string ORDER_CONTACTS = "O";
	public const string DEDUPLICATE_CONTACTS = "M";
	public const string EXIT = "X";

	public readonly string[] COMMANDS = new string[]
	{
		NEXT_PAGE,
        PREV_PAGE,
        GOTO_PAGE,
        PAGE_SIZE,
        CREATE_CONTACT,
		REVIEW_CONTACT,
        UPDATE_CONTACT,
        DELETE_CONTACT,
        FIND_CONTACTS,
		ORDER_CONTACTS,
        DEDUPLICATE_CONTACTS,
        EXIT
	};

	private List<Contact> allContacts;
	private List<Contact> filteredContacts;
	private int page;
	private int size;
	private bool isExit;

	public ContactBook(List<Contact> contacts = null!)
	{
		allContacts = (contacts == null) ? new List<Contact>() : contacts;
		filteredContacts = allContacts;
		page = 1;
		size = 10;
		isExit = false;
	}

	public void Start()
	{
		ShowWelcomeScreen();

		string input;
		do
		{
			do
			{
				ShowContacts();
				ShowInputOptions();
				input = GetInput();
			}
			while(!IsValidInput(input));

			ProcessInput(input);
		}
		while(!ConfirmExit());

		ShowExitScreen();
	}


    private void ShowWelcomeScreen()
	{
		Console.WriteLine("Welcome to Jeremy's Contact Book!");
		PressEnterContinue();
	}

	private void ShowContacts()
	{

	}



	private void ShowInputOptions()
	{

	}

	private string GetInput()
	{
		return "";
	}

        private bool IsValidInput(string input)
    {
        return true;
    }


        private void ProcessInput(string input)
    {
       
    }



	private bool ConfirmExit()
	{
		return true;
	}

	private void ShowExitScreen()
	{

	}

	private void PressEnterContinue()
	{
		Console.Write("Press ENTER to continue.");
		while(Console.ReadKey(true).Key != ConsoleKey.Enter);
	}
}