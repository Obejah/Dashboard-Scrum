using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Meldingspunt.Extentions;
 
using Models;
using MySql.Data.MySqlClient;

namespace Meldingspunt.Services
{
    public class ServiceBaseCLass
    {
        //connect

        //Get

        //Post
        public MySqlConnection Connection = new MySqlConnection();
        public void CreateConnection(string _serverName, string _dbName, string _userName, string _password)
        {
            MySqlConnection cnn;
            string connetionString = $"Data Source={_serverName};Initial Catalog={_dbName};User ID={_userName};Password={_password}";
            //string connetionString = "Server=mysql://localhost:3306;Database=meldingspunt;Uid=root;Pwd=root";
            //string connetionString = "Server=localhost;Port=3306;Database=meldingspunt;Uid=root;Pwd=root;connect timeout=100;";
            cnn = new MySqlConnection(connetionString);
            Extentions.testDbList.AddItemsToDB();
            SqlConnection cnn;
            //string connetionString = $"Data Source={_serverName};Initial Catalog={_dbName};User ID={_userName};Password={_password}";
            string connetionString = "Data Source=OBEJAH-LAPTOP\\SQLEXPRESS;Initial Catalog=Meldingspunt; Integrated Security=True; TrustServerCertificate=True";
            cnn = new SqlConnection(connetionString); 
            string connetionString = $"Data Source={_serverName};Initial Catalog={_dbName};User ID={_userName};Password={_password}";
            cnn = new SqlConnection(connetionString);
            Connection = cnn;
        }
        public MySqlDataReader CreateReaderAndSetQuery(string _queryS)
        {
            string queryString = _queryS;
            MySqlCommand query = new MySqlCommand(queryString, Connection);
            Extentions.Extentions.DebugOutput($"{Connection.State}");
            Connection.Open();
            Extentions.Extentions.DebugOutput("connection open");
            MySqlDataReader reader = query.ExecuteReader();
            return reader;
        }

        public virtual List<ModelBase> GetAll()
        {
            return null;
        }
        public virtual void Post(ModelBase _model)
        {

        }
        public virtual void Update(ModelBase model)
        {

        }
        public virtual void Create(ModelBase model)
        {

        }
        public virtual void Delete(ModelBase model)
        {

        }
        public virtual ModelBase GetById(int _id)
        {
            return null;
        }
    }
}
