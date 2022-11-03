using Meldingspunt.Models;
using Microsoft.Data.SqlClient;

namespace Meldingspunt.Services
{
    public class UserService : ServiceBaseCLass
    {
        public override List<ModelBase> GetAll()
        {
            List<ModelBase> users = new List<ModelBase>();

            SqlDataReader reader = CreateReaderAndSetQuery("");
            try
            {
                while (reader.Read())
                {
                    
                    User user = new User();

                    user.Id = (int)reader.GetValue(0);
                    user.Email = (string)reader.GetValue(1);
                    user.Username = (string)reader.GetValue(2);
                    user.Password = (string)reader.GetValue(3);

                    users.Add(user);

                }


                return users;
            }
            finally
            {
                
                Connection.Close();

            }
        }
        public List<ModelBase> GetById()
        {
            
        }
       
        public List<ModelBase> GetByMail(string _mail)
        {
            List<ModelBase> users = new List<ModelBase>();
            SqlDataReader reader = CreateReaderAndSetQuery($"Select * From users where Email = '{_mail}'");
            try
            {
                while (reader.Read())
                {

                    User user = new User();

                    user.Id = (int)reader.GetValue(0);
                    user.Email = (string)reader.GetValue(1);
                    user.Username = (string)reader.GetValue(2);
                    user.Password = (string)reader.GetValue(3);

                    users.Add(user);

                }


                return users;
            }
            finally
            {

                Connection.Close();

            }
        }
    }
}
