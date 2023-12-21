namespace PhoneBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello in PhonEBook app");
            Console.WriteLine("1 Add contact");
            Console.WriteLine("2 Display contact by number ");
            Console.WriteLine("3 Display all contacts");
            Console.WriteLine("4 Search contacts");
            Console.WriteLine("5 Delete Item After User Name");
            Console.WriteLine("6 Edit a user's phone number");
            Console.WriteLine("To exit insert 'end'");

            var userInput = Console.ReadLine();
            var phoneBook = new PhoneBook();
            while (true) {
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Insert number(it must be 9 digits long)");
                        var number = Console.ReadLine();
                        Console.WriteLine("Insert name");
                        var name = Console.ReadLine();
                        var newContact = new Contact(name, number);
                        phoneBook.AddContact(newContact);

                        break;
                    case "2":
                        Console.WriteLine("Insert number");
                        var numberToSearch = Console.ReadLine();
                        phoneBook.DisplayContact(numberToSearch);
                        break;
                    case "3":
                        phoneBook.DisplayAllContacts();
                        break;
                    case "4":
                        Console.WriteLine("Insert search phrase");
                        var searchPhrase = Console.ReadLine();
                        phoneBook.DisplayMatchingContacts(searchPhrase);
                        break;
                     
                    case "5":
                        Console.WriteLine("Enter the name of the person you want to remove");
                        var toDeleteName = Console.ReadLine();
                        phoneBook.DeleteContact(toDeleteName);

                        break;
                    case "6":
                        Console.WriteLine("Podaj imie urzytkownika którego numer chcesz zmienić");
                        var userName = Console.ReadLine();
                        Console.WriteLine("podaj numer który chcesz zapisać do tego urzytkownika");
                        var userNumber = Console.ReadLine();
                        phoneBook.Edit(userName, userNumber);
                        break;
                    case "end":
                        return;
                     default:
                        Console.WriteLine("Invalid operation");
                        break;
                }
                Console.WriteLine("Select operation");
                 userInput = Console.ReadLine();
            }
        }
    }
}