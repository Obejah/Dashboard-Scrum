using Meldingspunt.Models;
using Microsoft.Data.SqlClient;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Meldingspunt.Services
{
    public class MeldingService : ServiceBaseCLass
    {
        public override List<ModelBase> GetAll()
        {
            List<ModelBase> meldingen = new List<ModelBase>();

            SqlDataReader reader = CreateReaderAndSetQuery("");
            try
            {
                while (reader.Read())
                {
                    Melding melding = new Melding();

                    melding.Id = (int)reader.GetValue(0);
                    melding.OptiesId = (int)reader.GetValue(1);
                    melding.Other = (string)reader.GetValue(2);
                    melding.Date = (DateTime)reader.GetValue(3);

                    meldingen.Add(melding);
                }

                return meldingen;
            }
            finally
            {
                Connection.Close();
            }
        }

        public override ModelBase GetById(int _id)
        {
            Melding melding = new Melding();
            SqlDataReader reader = CreateReaderAndSetQuery($"Select * From melding where Id = '{_id}'");
            try
            {
                while (reader.Read())
                {
                    

                    melding.Id = (int)reader.GetValue(0);
                    melding.OptiesId = (int)reader.GetValue(1);
                    melding.Other = (string)reader.GetValue(2);
                    melding.Date = (DateTime)reader.GetValue(3);

                }

                return melding;

            }
            finally
            {
                Connection.Close();
            }
        }

        public List<ModelBase> GetByMeldingsPuntId(string _id)
        {
            List<ModelBase> meldingen = new List<ModelBase>();
            SqlDataReader reader = CreateReaderAndSetQuery($"Select * From melding where MeldingsPuntId = '{_id}'");
            try
            {
                while (reader.Read())
                {
                    Melding melding = new Melding();

                    melding.Id = (int)reader.GetValue(0);
                    melding.OptiesId = (int)reader.GetValue(1);
                    melding.Other = (string)reader.GetValue(2);
                    melding.Date = (DateTime)reader.GetValue(3);

                    meldingen.Add(melding);
                }

                return meldingen;
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
            string queryS = $"delete * from melding where ID = '{_model.Id}'";
            SqlCommand query = new SqlCommand(queryS, Connection);
            Connection.Open();
            query.ExecuteNonQuery();
            Connection.Close();
        }
    }
}

