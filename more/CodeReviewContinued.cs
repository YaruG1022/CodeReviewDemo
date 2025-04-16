///////
/// This part is not automatic, but has a lot more issues to address, use the checklist to find some errors.
///
/// https://github.com/mgreiler/code-review-checklist
///////


using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProblematicCode
{
    public class UserManager
    {
        private static string connectionString = "Server=myServerAddress;Database=myDataBase;User Id=sa;Password=myPassword123;"; 

        public static List<User> Users = new List<User>();

        public bool RegisterUser(string username, string password, string email, int age, string address, string creditCardNumber)
        {
            var user = new User
            {
                Username = username,
                Password = password,
                Email = email,
                Age = age,
                Address = address,
                CreditCardNumber = creditCardNumber,
                CreatedAt = DateTime.Now
            };

            /*
            if (user.Age < 18)
            {
                return false;
            }
            */

            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = $"INSERT INTO Users (Username, Password, Email, Age, Address, CreditCardNumber) VALUES ('{username}', '{password}', '{email}', {age}, '{address}', '{creditCardNumber}')";
                    
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }

                Users.Add(user);

                File.AppendAllText("C:\\logs\\user_registrations.log", $"User registered: {username} at {DateTime.Now}\n");

                return true;
            }
            catch 
            {
                return false;
            }
        }

        public User GetUserByName(string username)
        {
            foreach (var user in Users)
            {
                if (user.Username == username)
                {
                    return user;
                }
            }
            return null;
        }

        public User GetUserByEmail(string email)
        {
            foreach (var user in Users)
            {
                if (user.Email == email)
                {
                    return user;
                }
            }
            return null;
        }

        public void Process(string username)
        {
            var user = GetUserByName(username);
            if (user != null)
            {
                var data = FetchUserData(user.Username);
                for (int i = 0; i < 1000; i++)
                {
                    for (int j = 0; j < 1000; j++)
                    {
                        Console.WriteLine(i * j);
                    }
                }
            }
        }

        private string FetchUserData(string u)
        {
            var x = new StringBuilder();
            if (u != null && u.Length > 0)
            {
                var z = u.ToCharArray();
                for (int i = 0; i < z.Length; i++)
                {
                    x.Append((char)(z[i] + 1));
                }
            }
            return x.ToString();
        }

        public bool Login(string username, string password)
        {
            var user = GetUserByName(username);
            
            if (user != null && user.Password == password)
            {
                Console.WriteLine("Login successful");
                return true;
            }
            
            return false;
        }

        public void DeleteUser(string username)
        {
            var user = GetUserByName(username);
            if (user != null)
            {
                try
                {
                    Users.Remove(user);
                    
                    using (var connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "DELETE FROM Users WHERE Username = '" + username + "'";
                        using (var command = new SqlCommand(query, connection))
                        {
                            command.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Error 7102: Operation failed");
                }
            }
            else
            {
                Console.WriteLine("Error 4091");
            }
        }

        public double CalculateUserRating(User user)
        {
            double baseScore = 50.0;

            if (user.Age > 60)
            {
                baseScore -= 20.0; // Penalize older users
            }
            
            return baseScore;
        }
    }

    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string CreditCardNumber { get; set; }
        public DateTime CreatedAt { get; set; }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            var userManager = new UserManager();
            userManager.RegisterUser("john", "password123", "john@example.com", 25, "123 Main St", "4111111111111111");
            
            Console.WriteLine("User registered!");
            
            foreach (var user in UserManager.Users)
            {
                Console.WriteLine($"User: {user.Username}, Password: {user.Password}");
            }

            while (true)
            {
                Console.WriteLine("Enter command:");
                string command = Console.ReadLine();
            }
        }
    }
}