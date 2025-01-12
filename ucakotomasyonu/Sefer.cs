using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucakotomasyonu
{
    class Sefer
    {
        public int Id { get; set; }
        public string Nereden { get; set; }
        public string Nereye { get; set; }
        public string SeferTipi { get; set; }
        public DateTime TarihGidis { get; set; }
        public DateTime TarihDonus { get; set; }



        public List<Sefer> GetSeferler(DateTime gidisTarihi, string nereden, string nereye)
        {
            List<Sefer> seferler = new List<Sefer>();

            using (var connection = Veritabanı.Instance.GetConnection())
            {
                // connection.Open(); // Bağlantının açık olduğundan emin olun

                string query = @"SELECT * FROM seferler 
                         WHERE DATE(tarihGidiş) = DATE(@gidisTarihi) 
                         AND tarihGidiş > NOW() 
                         AND nereden = @nereden 
                         AND nereye = @nereye";

                using (var command = new MySqlCommand(query, connection))
                {
                    // Parametreleri ayarla
                    command.Parameters.AddWithValue("@gidisTarihi", gidisTarihi.Date);
                    command.Parameters.AddWithValue("@nereden", nereden);
                    command.Parameters.AddWithValue("@nereye", nereye);

                    // Debug amaçlı parametre değerlerini kontrol et
                    Console.WriteLine($"Gidiş Tarihi: {gidisTarihi.Date}");
                    Console.WriteLine($"Nereden: {nereden}, Nereye: {nereye}");

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var sefer = new Sefer
                            {
                                Id = reader.GetInt32("id"),
                                Nereden = reader.GetString("nereden"),
                                Nereye = reader.GetString("nereye"),
                                SeferTipi = reader.GetString("seferTipi"),
                                TarihGidis = reader.GetDateTime("tarihGidiş"),
                                TarihDonus = reader.IsDBNull(reader.GetOrdinal("tarihDönüş")) ? DateTime.MinValue : reader.GetDateTime("tarihDönüş")
                            };
                            seferler.Add(sefer);
                        }
                    }
                }
            }

            return seferler;
        }


        public List<Sefer> GetGidisDonusSeferler(DateTime gidisTarihi, DateTime donusTarihi, string nereden, string nereye)
        {
            List<Sefer> seferler = new List<Sefer>();

            using (var connection = Veritabanı.Instance.GetConnection())
            {
                // connection.Open(); // Bağlantının açık olduğundan emin olun
                string query = @"SELECT * FROM seferler 
                 WHERE DATE(tarihGidiş) = DATE(@gidisTarihi) 
                 AND tarihGidiş > NOW() 
                 AND nereden = @nereden 
                 AND nereye = @nereye
                 AND (tarihDönüş IS NULL OR DATE(tarihDönüş) = DATE(@donusTarihi))";



                using (var command = new MySqlCommand(query, connection))
                {
                    // Parametreleri ayarla
                    command.Parameters.AddWithValue("@gidisTarihi", gidisTarihi.Date);
                    command.Parameters.AddWithValue("@donusTarihi", donusTarihi.Date);

                    command.Parameters.AddWithValue("@nereden", nereden);
                    command.Parameters.AddWithValue("@nereye", nereye);

                    // Debug amaçlı parametre değerlerini kontrol et
                    Console.WriteLine($"Gidiş Tarihi: {gidisTarihi.Date}");
                    Console.WriteLine($"Nereden: {nereden}, Nereye: {nereye}");

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var sefer = new Sefer
                            {
                                Id = reader.GetInt32("id"),
                                Nereden = reader.GetString("nereden"),
                                Nereye = reader.GetString("nereye"),
                                SeferTipi = reader.GetString("seferTipi"),
                                TarihGidis = reader.GetDateTime("tarihGidiş"),
                                TarihDonus = reader.IsDBNull(reader.GetOrdinal("tarihDönüş")) ? DateTime.MinValue : reader.GetDateTime("tarihDönüş")
                            };
                            seferler.Add(sefer);
                        }
                    }
                }
            }

            return seferler;
        }









    }
}