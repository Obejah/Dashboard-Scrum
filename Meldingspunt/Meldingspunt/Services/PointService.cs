using Meldingspunt.Models;
using Microsoft.Data.SqlClient;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Meldingspunt.Services
{
    public class PointService : ServiceBaseCLass
    {
        public override List<ModelBase> GetAll()
        {
            List<ModelBase> points = new List<ModelBase>();

            SqlDataReader reader = CreateReaderAndSetQuery("");
            try
            {
                while (reader.Read())
                {
                    meldingsPunt Point = new meldingsPunt();

                    Point.UuId = (string)reader.GetValue(0);
                    Point.UserId = (int)reader.GetValue(1);
                    Point.Name = (string)reader.GetValue(2);

                    points.Add(Point);
                }

                return points;
            }
            finally
            {
                Connection.Close();
            }
        }

        public List<ModelBase> GetByUuId(int _id)
        {
            List<ModelBase> Points = new List<ModelBase>();
            SqlDataReader reader = CreateReaderAndSetQuery($"Select * From meldingspunt where UUID = '{_id}'");
            try
            {
                while (reader.Read())
                {
                    meldingsPunt point = new meldingsPunt();

                    point.UuId = (string)reader.GetValue(0);
                    point.UserId = (int)reader.GetValue(1);
                    point.Name = (string)reader.GetValue(2);


                    Points.Add(point);
                }

                return Points;
            }
            finally
            {
                Connection.Close();
            }
        }

        public List<ModelBase> GetByUser(string _user)
        {
            List<ModelBase> Points = new List<ModelBase>();
            SqlDataReader reader = CreateReaderAndSetQuery($"Select * From meldingspunt where User = '{_user}'");
            try
            {
                while (reader.Read())
                {
                    meldingsPunt point = new meldingsPunt();

                    point.UuId = (string)reader.GetValue(0);
                    point.UserId = (int)reader.GetValue(1);
                    point.Name = (string)reader.GetValue(2);


                    Points.Add(point);
                }

                return Points;
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
            string queryS = $"delete * from meldingspunt where ID = '{_model.Id}'";
            SqlCommand query = new SqlCommand(queryS, Connection);
            Connection.Open();
            query.ExecuteNonQuery();
            Connection.Close();
        }
    }
}

