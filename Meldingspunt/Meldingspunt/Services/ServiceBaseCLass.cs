using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Meldingspunt.Extentions;
using Models;

namespace Meldingspunt.Services
{
    public class ServiceBaseCLass
    {
        //connect

        //Get

        //Post
        public SqlConnection Connection = new SqlConnection();
        public void CreateConnection(string _serverName, string _dbName, string _userName, string _password)
        {
            Extentions.testDbList.AddItemsToDB();
            SqlConnection cnn;
            //string connetionString = $"Data Source={_serverName};Initial Catalog={_dbName};User ID={_userName};Password={_password}";
            string connetionString = "Data Source=OBEJAH-LAPTOP\\SQLEXPRESS;Initial Catalog=Meldingspunt; Integrated Security=True; TrustServerCertificate=True";
            cnn = new SqlConnection(connetionString); 
            Connection = cnn;
        }
        public SqlDataReader CreateReaderAndSetQuery(string _queryS)
        {
            string queryString = _queryS;
            SqlCommand query = new SqlCommand(queryString, Connection);
            Connection.Open();
            Extentions.Extentions.DebugOutput("connection open");
            SqlDataReader reader = query.ExecuteReader();
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
