using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cinema68.Entity;
using System.Data.SQLite;
using System.Security.Cryptography;

namespace Cinema68.Control
{
    class DBConnector
    {
        public void DropTables(SQLiteConnection conn)
        {
            SQLiteCommand sqlite_cmd;

            sqlite_cmd = conn.CreateCommand();

            string dropAccountTable = "DROP TABLE IF EXISTS 'Account'";

            string dropPaymentTable = "DROP TABLE IF EXISTS 'Payment'";

            string dropMovieTable = "DROP TABLE IF EXISTS 'Movie'";

            string dropAccountLogTable = "DROP TABLE IF EXISTS 'AccountLog'";


            sqlite_cmd.CommandText = dropAccountTable;
            sqlite_cmd.ExecuteNonQuery();

            sqlite_cmd.CommandText = dropPaymentTable;
            sqlite_cmd.ExecuteNonQuery();

            sqlite_cmd.CommandText = dropMovieTable;
            sqlite_cmd.ExecuteNonQuery();

            sqlite_cmd.CommandText = dropAccountLogTable;
            sqlite_cmd.ExecuteNonQuery();

        }
        public void CreateTable(SQLiteConnection conn)
        {
            DropTables(conn);

            SQLiteCommand sqlite_cmd;

            sqlite_cmd = conn.CreateCommand();

            string AccountTable = "CREATE TABLE IF NOT EXISTS `Account` (`email` VARCHAR(40), `password` VARCHAR(60), `is_admin` VARCHAR, PRIMARY KEY (`email`));";
            string PaymentTable = "CREATE TABLE IF NOT EXISTS `Payment` (`payment_number` INT(5) NOT NULL,`card_number` INT(16),`cvv` INT(3),`expiration` DATE,`num_tickets` INT(15) DEFAULT '1',	`price` DECIMAL,`is_valid` BOOLEAN,PRIMARY KEY(`payment_number`)); ";
            string MovieTable = "CREATE TABLE IF NOT EXISTS `Movie` ( `movie_ID` INT(5) NOT NULL, `movie_name` VARCHAR(20), `movie_rating` VARCHAR(10), `movie_genre` TINYINT,  `movie_length` TIME DEFAULT '00:00:00',  `movie_director` VARCHAR(20),  `movie_releasedate` DATE,  `movie_datetime` DATETIME, `movie_synopsis` TEXT(500),  `movie_cover` BLOB,  PRIMARY KEY (`movie_ID`));";
            string AccountLogTable = "CREATE TABLE IF NOT EXISTS `AccountLog` (`log_ID` INT,`date` DATE,`time` TIME,`event` VARCHAR,PRIMARY KEY (`log_ID`));";
            

            // for account
            sqlite_cmd.CommandText = AccountTable;
            sqlite_cmd.ExecuteNonQuery();

            // for Payment
            sqlite_cmd.CommandText = PaymentTable;
            sqlite_cmd.ExecuteNonQuery();

            // for Movie
            sqlite_cmd.CommandText = MovieTable;
            sqlite_cmd.ExecuteNonQuery();

            // for account table
            sqlite_cmd.CommandText = AccountLogTable;
            sqlite_cmd.ExecuteNonQuery();
            conn.Close();
        }


        public void InsertData(SQLiteConnection conn)
        {
            conn.Open();
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();

            //Fill Account Table
            sqlite_cmd.CommandText = "INSERT INTO `Account` (`email`, `password`, `is_admin`) VALUES('Cinema68Admin@augusta.edu', 'b9c950640e1b3740e98acb93e669c65766f6670dd1609ba91ff41052ba48c6f3', 'true');";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO `Account`(`email`, `password`, `is_admin`) VALUES('jvick@gmail.com',  'b9c950640e1b3740e98acb93e669c65766f6670dd1609ba91ff41052ba48c6f3', 'false');";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO `Account`(`email`, `password`, `is_admin`) VALUES('hhoward@gmail.com',  'b9c950640e1b3740e98acb93e669c65766f6670dd1609ba91ff41052ba48c6f3', 'false');";
            sqlite_cmd.ExecuteNonQuery();

            //Fill Payment Table
            sqlite_cmd.CommandText = "INSERT INTO `Payment`(`payment_number`, `card_number`, `cvv`, `expiration`, `num_tickets`, `price`, `is_valid`) VALUES('570', '4485679076972808', '749', '6/2023', '2', '20', 'true');";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO `Payment`(`payment_number`, `card_number`, `cvv`, `expiration`, `num_tickets`, `price`, `is_valid`) VALUES('571', '4024007147874977', '859', '10/2021', '3', '30', 'true');";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO `Payment`(`payment_number`, `card_number`, `cvv`, `expiration`, `num_tickets`, `price`, `is_valid`) VALUES('572', '4929150413661714', '774', '10/2028', '1', '10', 'true');";
            sqlite_cmd.ExecuteNonQuery();

            //Fill Movie Table
            sqlite_cmd.CommandText = "INSERT INTO `Movie`(`movie_ID`, `movie_name`, `movie_rating`, `movie_genre`, `movie_length`, `movie_director`, `movie_releasedate`, `movie_datetime`, `movie_synopsis`, `movie_cover`) VALUES('1', 'Forest Gump', 'PG-13', 'Drama', '02:22:00', 'Robert Zemeckis', '1994-07-06', '2021-12-12 15:30:00', 'The presidencies of Kennedy and Johnson, the Vietnam War, the Watergate scandal and other historical events unfold from the perspective of an Alabama man with an IQ of 75, whose only desire is to be reunited with his childhood sweetheart.', '(readfile(logo.jpg))');";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO `Movie`(`movie_ID`, `movie_name`,  `movie_rating`,`movie_genre`, `movie_length`, `movie_director`, `movie_releasedate`, `movie_datetime`, `movie_synopsis`, `movie_cover`) VALUES('2', 'The Matrix', 'R', 'Action', '02:16:00', 'Lana Wachowski', '1999-03-31', '2021-12-12 15:30:00', 'When a beautiful stranger leads computer hacker Neo to a forbidding underworld, he discovers the shocking truth--the life he knows is the elaborate deception of an evil cyber-intelligence.', '(readfile(logo.jpg))');";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO `Movie`(`movie_ID`, `movie_name`, `movie_rating`, `movie_genre`, `movie_length`, `movie_director`, `movie_releasedate`, `movie_datetime`, `movie_synopsis`, `movie_cover`) VALUES('3', 'Step Brothers','R',  'Comedy', '01:38:00', 'Adam McKay', '2008-07-25', '2021-12-12 15:30:00', 'Two aimless middle-aged losers still living at home are forced against their will to become roommates when their parents marry.', '(readfile(logo.jpg))');";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO `Movie`(`movie_ID`, `movie_name`,  `movie_rating`,`movie_genre`, `movie_length`, `movie_director`, `movie_releasedate`, `movie_datetime`, `movie_synopsis`, `movie_cover`) VALUES('4', 'Inception','PG-13', 'Action', '02:28:00', 'Christopher Nolan', '2010-07-13', '2021-12-12 15:30:00', 'A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O., but his tragic past may doom the project and his team to disaster.', '(readfile(logo.jpg))');";
            sqlite_cmd.ExecuteNonQuery();

            //Fill Account Log Table
            sqlite_cmd.CommandText = "INSERT INTO AccountLog(`log_ID`, `date`, `time`, `event`) VALUES('1', '2021-12-12', '13:30:00', 'LogIn');";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO AccountLog(`log_ID`, `date`, `time`, `event`) VALUES('2', '2021-12-12', '13:45:30', 'LogOut');";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO AccountLog(`log_ID`, `date`, `time`, `event`) VALUES('3', '2021-12-14', '10:20:10', 'LogIn');";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO AccountLog(`log_ID`, `date`, `time`, `event`) VALUES('4', '2021-12-14', '10:30:00', 'LogOut');";
            sqlite_cmd.ExecuteNonQuery();

            conn.Close();
        }


        public void ReadData(SQLiteConnection conn)
        {
            conn.Open();
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM Account";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            string myreaderAccount;
            while (sqlite_datareader.Read())
            {
                myreaderAccount = sqlite_datareader.GetString(0);
            }

            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM Payment";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            string myreaderPayment;
            while (sqlite_datareader.Read())
            {
                myreaderPayment = sqlite_datareader.GetString(0);
            }

            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM Movie";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            string myreaderMovie;
            while (sqlite_datareader.Read())
            {
                myreaderMovie = sqlite_datareader.GetString(0);
            }

            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM AccountLog";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            string myreaderAccountLog;
            while (sqlite_datareader.Read())
            {
                myreaderAccountLog = sqlite_datareader.GetString(0);
            }



            conn.Close();
        }

        public SQLiteConnection CreateConnection()
        {

            SQLiteConnection sqlite_conn;
            // Create a new database connection:
            sqlite_conn = new SQLiteConnection("Data Source=database.db; Version = 3; New = True; Compress = True; ");
            // Open the connection:
            try
            {
                sqlite_conn.Open();
            }
            catch 
            {
                throw new Exception("Connection does not work. ");
            }
            return sqlite_conn;
        }

        public string GetUser(string email, string pwd)
        {

            string hashedData = ComputeSha256Hash(pwd);
            SQLiteConnection sqlite_conn = new SQLiteConnection();
            SQLiteCommand sqlite_cmd;
            SQLiteDataReader sqlite_datareader;
            sqlite_conn.Open();
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM Account WHERE email = " + email + " AND password = " + hashedData + ";";
           

            string myreader = "";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                myreader = sqlite_datareader.GetString(0);
            }
            sqlite_conn.Close();
            return myreader;
        }

        public bool ValidateUser(string email, string pwd)
        {
            string hashedData = ComputeSha256Hash(pwd);
            using (SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source=database.db; Version = 3; New = True; Compress = True; "))
            {
                sqlite_conn.Open();
                SQLiteCommand sqlite_cmd;
                SQLiteDataReader sqlite_datareader;
                
                using (sqlite_cmd = sqlite_conn.CreateCommand())
                {
                    sqlite_cmd.CommandText = "SELECT EXISTS(SELECT 1 FROM Account WHERE email = '" + email + "'AND password = '" + hashedData + "');";

                    int n = Convert.ToInt32(sqlite_cmd.ExecuteScalar());
                    sqlite_datareader = sqlite_cmd.ExecuteReader();

                    if (n == 1)
                    {
                        sqlite_conn.Close();
                        return true;
                    }
                    sqlite_conn.Close();
                    return false;
                }
            }
            
        }
        public string ComputeSha256Hash(string pwd)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(pwd));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
