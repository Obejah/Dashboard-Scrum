using Microsoft.Data.SqlClient;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using Meldingspunt.Models;
using Meldingspunt.Services;

namespace Optionspunt.Services
{
    public class OptionService : ServiceBaseCLass
    {
        public override List<ModelBase> GetAll()
        {
            List<ModelBase> Options = new List<ModelBase>();

            SqlDataReader reader = CreateReaderAndSetQuery("");// pleaseAddQuery
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
            SqlDataReader reader = CreateReaderAndSetQuery(""); // pleaseAddQuery
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
            SqlCommand query = new SqlCommand(queryS, Connection);
            Connection.Open();
            query.ExecuteNonQuery();
            Connection.Close();
        }
        public override void Delete(ModelBase _model)
        {
            string queryS = $"delete * from Option where ID = '{_model.Id}'";
            SqlCommand query = new SqlCommand(queryS, Connection);
            Connection.Open();
            query.ExecuteNonQuery();
            Connection.Close();
        }
    }
}
