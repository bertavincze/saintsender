using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SaintSender
{
    public class DataService
    {
        public static void SerializeLoginData(string email, string password)
        {
            if (!Directory.Exists("AppData")) Directory.CreateDirectory("AppData");
            Stream stream = File.Open(@"AppData\login.dat", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            //Serialize with hashed password:
            //formatter.Serialize(stream, new UserData(email, Convert.ToBase64String(PasswordService.ComputeHash(password, PasswordService.GenerateSalt()))));
            formatter.Serialize(stream, new UserData(email, password));
            stream.Close();
        }

        public static UserData DeSerializeLoginData()
        {
            Stream stream = new FileStream(@"AppData\login.dat", FileMode.Open, FileAccess.Read);
            BinaryFormatter formatter = new BinaryFormatter();
            UserData userData = (UserData)formatter.Deserialize(stream);
            stream.Close();
            return userData;
        }
    }
}
