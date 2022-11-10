using Microsoft.Data.SqlClient;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using Models;
using Meldingspunt.Services;
using MySql.Data.MySqlClient;
namespace Optionspunt.Services
{
    public class OptionService : ServiceBaseCLass
    {
        public override List<ModelBase> GetAll()
        {
            List<ModelBase> Options = new List<ModelBase>();

            MySqlDataReader reader = CreateReaderAndSetQuery("");// pleaseAddQuery
            try
            {
                while (reader.Read())
                {
                    Option option = new Option();

                    option.Id = (int)reader.GetValue(0);
                    option.MeldingsPuntiD = (string)reader.GetValue(1);
                    option.OptionName = (string)reader.GetValue(2);
                    option.Urgency = (int)reader.GetValue(3);

                    Options.Add(option);
                }

                return Options;
            }
            finally
            {
                Connection.Close();
            }
        }


        public override ModelBase GetById(int _id)
        {
            Option option = new Option();
            MySqlDataReader reader = CreateReaderAndSetQuery(""); // pleaseAddQuery
            try
            {
                while (reader.Read())
                {
                  

                    option.Id = (int)reader.GetValue(0);
                    option.MeldingsPuntiD = (string)reader.GetValue(1);
                    option.OptionName = (string)reader.GetValue(2);
                    option.Urgency = (int)reader.GetValue(3);


                }
                return option;

            }
            finally
            {
                Connection.Close();
            }
        }
        public override void Post(ModelBase _model)
        {
            string queryS = $"";
            MySqlCommand query = new MySqlCommand(queryS, Connection);
            Connection.Open();
            query.ExecuteNonQuery();
            Connection.Close();
        }
        public override void Delete(ModelBase _model)
        {
            string queryS = $"delete * from Option where ID = '{_model.Id}'";
            MySqlCommand query = new MySqlCommand(queryS, Connection);
            Connection.Open();
            query.ExecuteNonQuery();
            Connection.Close();
        }
    }
}
