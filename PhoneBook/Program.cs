namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            //  создаём пустой список с типом данных Contact
            var phoneBook = new List<Contact>();

            // добавляем контакты
            phoneBook.Add(new Contact("Игорь", "Николаев", 79990000001, "igor@example.com"));
            phoneBook.Add(new Contact("Сергей", "Довлатов", 79990000010, "serge@example.com"));
            phoneBook.Add(new Contact("Анатолий", "Карпов", 79990000011, "anatoly@example.com"));
            phoneBook.Add(new Contact("Валерий", "Леонтьев", 79990000012, "valera@example.com"));
            phoneBook.Add(new Contact("Сергей", "Брин", 799900000013, "serg@example.com"));
            phoneBook.Add(new Contact("Иннокентий", "Смоктуновский", 799900000013, "innokentii@example.com"));

            DoSorting(phoneBook);
        }

        
        /// <summary>
        /// Sort contacts by name and then lastname consistently in ascending and descending order
        /// </summary>
        /// <param name="phoneBook"></param>
        private static void DoSorting(List<Contact> phoneBook)
        {
            //sorting OrderBy
            var sortedContacts = phoneBook.OrderBy(s => s.Name)
                                          .ThenBy(s => s.LastName);
            Console.WriteLine("Сортировка: Вариант 1");
            foreach (var contact in sortedContacts)
            {
                Console.WriteLine(contact.Name + " " + contact.LastName + " " + contact.PhoneNumber + " " + contact.Email);
            }

            //sorting OrderByDescending
            sortedContacts = phoneBook.OrderByDescending(s => s.Name)
                                          .ThenByDescending(s => s.LastName);
            Console.WriteLine("Сортировка: Вариант 2");
            foreach (var contact in sortedContacts)
            {
                Console.WriteLine(contact.Name + " " + contact.LastName + " " + contact.PhoneNumber + " " + contact.Email);
            }
            Console.ReadLine();  
        }
    }
    public class Contact // модель класса
    {
        public Contact(string name, string lastName, long phoneNumber, String email) // метод-конструктор
        {
            Name = name;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public String Name { get; }
        public String LastName { get; }
        public long PhoneNumber { get; }
        public String Email { get; }
    }
}