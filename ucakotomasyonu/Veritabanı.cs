using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucakotomasyonu
{

    class Veritabanı
    {

        // Singleton için private static instance
        private static Veritabanı _instance;

        // MySqlConnection nesnesi
        private MySqlConnection _connection;

        // Bağlantı cümlesi (Connection String)
        private readonly string _connectionString = "Server=localhost;Database=ucakotomasyondb;User ID=root;Password=;";

        // Constructor'ı private yaparak dışardan erişimi engelle
        private Veritabanı() { }

        // Singleton instance erişim metodu
        public static Veritabanı Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Veritabanı();
                }
                return _instance;
            }
        }

        // Bağlantı nesnesini dönen ve bağlantı durumunu kontrol eden metot
        public MySqlConnection GetConnection()
        {
            if (_connection == null || _connection.State == System.Data.ConnectionState.Closed)
            {
                _connection = new MySqlConnection(_connectionString);
                _connection.Open();
            }

            return _connection;
        }

        // Bağlantıyı kapatma metodu
        public void CloseConnection()
        {
            if (_connection != null && _connection.State == System.Data.ConnectionState.Open)
            {
                _connection.Close();
            }
        }

        // Bağlantı durumunu kontrol eden metot
        public bool IsConnected()
        {
            if (_connection == null)
            {
                return false;
            }

            return _connection.State == System.Data.ConnectionState.Open;
        }

        

    }
    
}
