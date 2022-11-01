using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Meldingspunt.Services
{
    public class ServiceBaseCLass
    {
        //connect

        //Get

        //Post
        public void CreateConnection()
        {
            string connetionString = null;
            SqlConnection cnn;
            connetionString = "Data Source=ServerName;Initial Catalog=DatabaseName;User ID=UserName;Password=Password";
            cnn = new SqlConnection(connetionString);
            try
            {
                cnn.Open();
                Extentions.Extentions.DebugOutput("connection open");
                cnn.Close();
            }
            catch (Exception ex)
            {
                Extentions.Extentions.DebugOutput("cannot open Connection");
            }
        }
    }
    
}
