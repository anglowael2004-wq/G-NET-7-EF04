using Microsoft.Identity.Client;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Add Customer");
                Console.WriteLine("2. Open Account");
                Console.WriteLine("3. Update Account Status");
                Console.WriteLine("4. Remove Account From Customer");
                Console.WriteLine("5. List Customers");
                Console.WriteLine("0. Exit");
                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "1": AddCustomer(); break;
                    case "2": OpenAccount(); break;
                    case "3": UpdateAccountStatus(); break;
                    case "4": RemoveAccount(); break;
                    case "5": ListCustomers(); break;
                    case "0": return;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;


                }

            }
            static void AddCustomer()
            {
                using var db = new bankdbcontext();
                Console.WriteLine("name:");
                var name = Console.ReadLine();
                Console.WriteLine("email:");
                var email = Console.ReadLine();
                Console.WriteLine("National id:");
                var nationalId = Console.ReadLine();
                Console.WriteLine("dob:");
                var dob = Console.ReadLine();
                Console.WriteLine("phone:");
                var phone = Console.ReadLine();
                Console.WriteLine("address:");
                var address = Console.ReadLine();
                Console.WriteLine("type(Individual/Business):");
                var type = Console.ReadLine();
                var customer = new Customer
                {
                    FullName = name,
                    Email = email,
                    NationalId = nationalId,
                    DateOfBirth = DateTime.Parse(dob),
                    PhoneNumber = phone,
                    Address = address,
                    CustomerType = type,
                };
                db.Customers.Add(customer);
                db.SaveChanges();
            }
            static void OpenAccount()
            {
                using var db = new bankdbcontext();
                Console.WriteLine("Account Number :");
                var accnuber = Console.ReadLine();
                Console.WriteLine("account type (Savings/Checking):");
                var type = Console.ReadLine();
                Console.WriteLine("Branch Code:");
                var branchCode = Console.ReadLine();
                Console.WriteLine("Customer id:");
                var customerId = Console.ReadLine();
                var account = new Account
                {
                    AccountNumber = int.Parse(accnuber),
                    AccountType = type,
                    OpeningDate = DateTime.Now,
                    CurrentBalance = 0,
                    branchCode = int.Parse(branchCode),


                };
                db.Accounts.Add(account);
                db.SaveChanges();
            }
            static void UpdateAccountStatus()
            {
                using var db = new bankdbcontext();
                Console.WriteLine("Enter Account Number:");
                var accNumber = Console.ReadLine();
                Console.WriteLine("Customer Id:");
                var customerId = Console.ReadLine();
                db.SaveChanges();
            }
            static void RemoveAccount()
            {
                using var db = new bankdbcontext();
                Console.WriteLine("Enter Account Number:");
                var accNumber = Console.ReadLine();
                Console.WriteLine("Customer Id:");
                var customerId = Console.ReadLine();
                db.SaveChanges();
            }
            static void ListCustomers()
            {
                using var db = new bankdbcontext();
                     


            } }
    }
}
