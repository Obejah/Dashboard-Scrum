using Models;

namespace Meldingspunt.Extentions
{
    public class testDbList
    {
        public static List<User> UserDummyDB= new List<User>();

        public static List<Melding> MeldingDummyDB=new List<Melding>();

        public static List<Option>  OptionDummyDB=new List<Option>();

        public static List<Point>  PointDummyDB=new List<Point>();

        public static void AddItemsToDB()
        {
            Random r = new Random();
            for (int i = 0; i < 5; i++)
            {
                string uid = new Guid().ToString();
                UserDummyDB.Add(new User { Id = i, Email = $"{i}{i + i * 4}@testmail.com", Password = $"{i}{i + i * 4}", Username = $"Sir{i}{i + i * 2}" });
                MeldingDummyDB.Add(new Melding {  Id = i, Date = DateTime.Now, OptiesId = i, Other = ""});
                OptionDummyDB.Add(new Option { Id = i, MeldingsPuntiD = uid, OptionName = $"Leuke optie{i * 2}", Urgency = r.Next(1, 3) });
                PointDummyDB.Add(new Point { Id = i, Name = $"kamer {i}", UserId = 1, UuId = uid});
            }
        }
    }
}
