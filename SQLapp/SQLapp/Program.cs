using MySql.Data.MySqlClient;
using System;
using System.Linq.Expressions;

namespace SQLApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool exit = true;
            
            var builder = new MySqlConnectionStringBuilder
            {
                Server = "127.0.0.1",
                UserID = "root",
                Password = "",
                Database = "mysqltest",
            };

            var connection = new MySqlConnection(builder.ConnectionString);
            connection.Open();

            while (exit)
            {
                Console.Clear();
                Console.WriteLine(" Press '1' to add record to database \n Press '2' to delete record from database. \n Press '3' to show all records in database. \n Press '4' to exit program. ");

                switch (Console.ReadLine())
                {
                    case "1":
                        //InsertNewRawToDB(connection, "Arek", "Walęzak", 30);
                        //InsertNewRawToDB(connection, "Kinga", "Walęzak", 55);
                        //InsertNewRawToDB(connection, "Mateusz", "Gryboś", 17);
                        Console.WriteLine("Type name.");
                        string imie = Console.ReadLine();
                        Console.WriteLine("Type surname.");
                        string nazwisko = Console.ReadLine();
                        Console.WriteLine("Type age.");
                        int.TryParse(Console.ReadLine(), out int result);
                        int wiek = result;
                        InsertNewRawToDBWithoutFKNumber(connection, imie, nazwisko, wiek);
                        break;
                    case "2":
                        Console.WriteLine("Which record from table 'osoby' would you like to delete?");
                        string nameOrSurname = Console.ReadLine();
                        DeleteSpecificRecordFromDB(connection, "osoby", nameOrSurname);
                        break;
                    case "3":
                        ReadAllFromDBWithTableAsParameter(connection, "osoby");
                        break;
                    case "4":
                        exit = false;
                        break;
                    default:
                        Console.WriteLine("You didn't choose any option. Press any key to continue.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        public static void InsertNewRawToDBWithoutFKNumber(MySqlConnection connection, string imie, string nazwisko, int wiek)
        {
            using (MySqlCommand command = connection.CreateCommand())
            {
                command.CommandText = @"INSERT INTO osoby(imie, nazwisko, wiek) VALUES (@imie, @nazwisko, @wiek)";
                command.Parameters.AddWithValue("@imie", imie);
                command.Parameters.AddWithValue("@nazwisko", nazwisko);
                command.Parameters.AddWithValue("@wiek", wiek);

                using (MySqlDataReader reader = command.ExecuteReader())
                { }
            }
            Console.WriteLine("Press any key to continue.");
        }

        public static void ReadAllFromDBWithTableAsParameter(MySqlConnection connection, string tableName)
        {
            using (MySqlCommand command = connection.CreateCommand())
            {
                command.CommandText = $"SELECT * FROM {tableName}";

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader.GetString(0)} - {reader.GetString(1)} - {reader.GetString(2)} - {reader.GetString(3)}");
                    }
                }
            }
            Console.WriteLine("Press any key to continue.");

            Console.ReadKey();
        }

        public static void DeleteAllFromDB(MySqlConnection connection, string tableName)
        {
            using (MySqlCommand command = connection.CreateCommand())
            {
                command.CommandText = $"DELETE FROM {tableName} ";

                using (MySqlDataReader reader = command.ExecuteReader())
                { }
            }
            Console.WriteLine("Press any key to continue.");
        }

        public static void DeleteSpecificRecordFromDB(MySqlConnection connection, string tableName, string nameOrSurname)
        {
            using (MySqlCommand command = connection.CreateCommand())
            {
                command.CommandText = $"DELETE FROM {tableName} WHERE imie = '{nameOrSurname}' OR nazwisko = '{nameOrSurname}'";

                using (MySqlDataReader reader = command.ExecuteReader())
                { }
            }
            Console.WriteLine("Press any key to continue.");
        }

        public static void ReadDataFormatted(MySqlConnection connection)
        {
            using (MySqlCommand command = connection.CreateCommand())
            {
                command.CommandText = $@"SELECT osoby.imie, osoby.nazwisko, osoby.wiek, numery.numer
                                        FROM osoby
                                        INNER JOIN numery ON osoby.FK_numery = numery.id";

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader.GetString(0)} - {reader.GetString(1)} - {reader.GetString(2)} - {reader.GetString(3)}");
                    }
                }
            }
        }

    }
}