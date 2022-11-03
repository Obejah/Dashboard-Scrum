using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Meldingspunt.Extentions;
using Meldingspunt.Models;

namespace Meldingspunt.Services
{
    public class ServiceBaseCLass
    {
        //connect

        //Get

        //Post
        public SqlConnection Connection = new SqlConnection();
        public void CreateConnection()
        {
            SqlConnection cnn;
            string connetionString = "Data Source=ServerName;Initial Catalog=DatabaseName;User ID=UserName;Password=Password";
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
    }
}
