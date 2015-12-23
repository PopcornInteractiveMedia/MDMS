using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;
using System.Data.SqlClient;
namespace BO
{
    public class Operation
    {
        public SqlConnection create_connection()
        {
            string ConnString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=G:\C#\Multimedia Database Management System\MDMS.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            SqlConnection Conn = new SqlConnection(ConnString);
            Conn.Open();
            return Conn;
        }

        public void SaveInformation(string query)
        {
            try
            {
                SqlConnection Conn = create_connection();
                SqlCommand cmd = new SqlCommand(query, Conn);
                cmd.ExecuteNonQuery();
                Conn.Close();
                //MessageBox.Show("Added Product Information To Stock List Successfully", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }


        
    }

    
}
