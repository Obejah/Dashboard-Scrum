using Models;
using Microsoft.Data.SqlClient;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using MySql.Data.MySqlClient;
namespace Meldingspunt.Services
{
    public class PointService : ServiceBaseCLass
    {
        private int userId;
        public PointService(int _userid)
        {
            userId = _userid;
        }
        public override List<ModelBase> GetAll()
        {
            List<ModelBase> points = new List<ModelBase>();

<<<<<<< HEAD
            MySqlDataReader reader = CreateReaderAndSetQuery($"select * from meldingspunten where UserID = '{userId}'"); 
            Extentions.Extentions.DebugOutput($"{reader.IsClosed}");
=======
            SqlDataReader reader = CreateReaderAndSetQuery($"select * from meldingspunt where UserID = '{userId}'");
>>>>>>> ca078ef6e034f09695fedaf2259ef27da50ee4b4
            try
            {
                while (reader.Read())
                {
                    Models.Point Point = new Models.Point();

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

        public override ModelBase GetById(int _id)
        {
            Models.Point point =  new Models.Point();

            MySqlDataReader reader = CreateReaderAndSetQuery($"Select * From meldingspunt where UUID = '{_id}'");
            try
            {
                while (reader.Read())
                {

                    point.UuId = (string)reader.GetValue(0);
                    point.UserId = (int)reader.GetValue(1);
                    point.Name = (string)reader.GetValue(2);

                }
                return point;

            }
            finally
            {
                Connection.Close();
            }
        }

        public List<ModelBase> GetByUser(string _user)
        {
            List<ModelBase> Points = new List<ModelBase>();
            MySqlDataReader reader = CreateReaderAndSetQuery($"Select * From meldingspunt where User = '{_user}'");
            try
            {
                while (reader.Read())
                {
                    Models.Point point = new Models.Point();

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
            MySqlCommand query = new MySqlCommand(queryS, Connection);
            Connection.Open();
            query.ExecuteNonQuery();
            Connection.Close();
        }
        public override void Delete(ModelBase _model)
        {
            string queryS = $"delete * from meldingspunt where ID = '{_model.Id}'";
            MySqlCommand query = new MySqlCommand(queryS, Connection);
            Connection.Open();
            query.ExecuteNonQuery();
            Connection.Close();
        }
    }
}

