using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    internal class PhoneBook
    {
        public List<Contact> Contacts { get; set; } = new List<Contact>();
        public void AddContact(Contact contact)
        {
            if(contact.Number.Length==9) {
                Contacts.Add(contact);
            }
            else {
                Console.WriteLine("You have entered an invalid number");
            }
            
        }
        private void DisplayContactDetails(Contact contact)
        {
            Console.WriteLine($"Contact: {contact.Name} , {contact.Number} ");
        }
        private void DisplayContactsDetails(List<Contact> contacts)
        {
            foreach (Contact contact in contacts)
            {
                DisplayContactDetails(contact);
            }
        }

        public void DisplayContact(string number)
        {
            Contact contact = Contacts.FirstOrDefault(c => c.Number == number);
            if (contact == null)
            {
                Console.WriteLine("Contact is not found");
            }
            else
            {
                DisplayContactDetails(contact);
            }
        }
        public void DisplayAllContacts()
        {
            DisplayContactsDetails(Contacts);
        }

        public void DisplayMatchingContacts(string searched)
        {
            var matchingContacts = Contacts.Where(c => c.Name.Contains(searched)).ToList();
            DisplayContactsDetails(matchingContacts); 
        }

       
        public void DeleteContact(string name)
        {
            var toDeleteName = Contacts.FirstOrDefault(c => c.Name == name);
            Contacts.Remove(toDeleteName);

        }
        public void Edit(string name, string number)
        {
            foreach(Contact contact in Contacts) {
                if(contact.Name == name)
                {
                    var usersName = Contacts.FirstOrDefault(c => c.Name == name);
                    if (number.Length == 9)
                    {
                        usersName.Number = number;
                    }
                    else
                    {
                        Console.WriteLine("You have entered an invalid phone number");
                    }
                }
                else { Console.WriteLine("The username you entered does not exist"); }
                
            }
            
           

        }
    }
}
