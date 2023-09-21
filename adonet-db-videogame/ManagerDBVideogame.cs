using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;


namespace adonet_db_videogame
{
    public static class ManagerDBVideogame
    {
        private static string connectionString = "Data Source=localhost;Initial Catalog=Videogames;Integrated Security=True";

        public static bool AddVideogame(Videogame videogameToAdd)
        {
            
            // dichiaro un nuovo oggetto di tipo SqlConnection in un blocco using in modo da non dover chiudere la connesione al DB perchè lo fa in automatico il blocco
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {

                    // autentico bel DB l'oggetto chiamando il metodo Open
                    sqlConnection.Open();

                    string query = "INSERT INTO videogames (name, overview, release_date, software_house_id) VALUES (@Name, @Overview, @Release_date, @Software_house_id);";

                    SqlCommand cmd = new SqlCommand(query, sqlConnection);
                    cmd.Parameters.Add(new SqlParameter("@Name", videogameToAdd.Name));
                    cmd.Parameters.Add(new SqlParameter("@Overview", videogameToAdd.Overview));
                    cmd.Parameters.Add(new SqlParameter("@Release_date", videogameToAdd.Release_date));
                    cmd.Parameters.Add(new SqlParameter("@Software_house_id", videogameToAdd.Software_house_id));

                    int affectedRows = cmd.ExecuteNonQuery();

                    if(affectedRows > 0)
                    {
                        return true;
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                return false;
            }
        }
    }
}
