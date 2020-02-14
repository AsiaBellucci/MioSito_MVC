using MioSito.Models.Servicies.Application.Interfaces;
using MioSito.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;



namespace MioSito.Models.Servicies.Infrastructure
{
    public class SqlServerDatabaseConnector : IDatabaseConnector
    {
        public DataSet Query(string query)
        {
            using (SqlConnection conn = new SqlConnection("Server=superdatabaseditest.database.windows.net;Database=Superdatabase;User Id=SuperUser;Password=MarcoGraziottiRegna33;"))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn)) 
                {
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                    DataSet dataSet = new DataSet();
                    DataTable dataTable = new DataTable();
                    dataSet.Tables.Add(dataTable);
                    dataTable.Load(reader);
                    return dataSet;
                    }
                }
            }
        }

        public void InsertQuery(string insertquery, AddCourseViweModel corso)
        {
            using (SqlConnection conn = new SqlConnection("Server=superdatabaseditest.database.windows.net;Database=Superdatabase;User Id=SuperUser;Password=MarcoGraziottiRegna33;"))
            {
                conn.Open();
                using(SqlCommand cmd = new SqlCommand(insertquery, conn))
                {
                    cmd.Parameters.AddWithValue("@Title", corso.Title);
                    cmd.Parameters.AddWithValue("@Description", corso.Description);
                    cmd.Parameters.AddWithValue("@ImagePath", corso.ImagePath);
                    cmd.Parameters.AddWithValue("@Author", corso.Author);
                    cmd.Parameters.AddWithValue("@Email", corso.Email);
                    cmd.Parameters.AddWithValue("@Rating", corso.Rating);
                    cmd.Parameters.AddWithValue("@FullPrice", corso.FullPrice);
                    cmd.Parameters.AddWithValue("@Valuta", corso.Valuta);
                    cmd.Parameters.AddWithValue("@CurrentPrice", corso.CurrentPrice);
                    cmd.Parameters.AddWithValue("@ValutaCor", corso.ValutaCor);
                    
                    int result = cmd.ExecuteNonQuery();
                    if (result < 0)
                        Console.WriteLine("ERROR inserting data into db");
                    else
                    {
                        Console.WriteLine("Succeafull inserting data");
                    }
                }
            }
        }
    }
}
