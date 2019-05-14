using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ExploringNETFramework
{
    public class MySettings
    {
        [XmlElement("num")]
        public int MyNumber { get; set; }
        public string MyString { get; set; }

        public void Save()
        {
            //es casi lo mismo que un try finally pero no tenemos que hacer un writer.close ni stream.close porque se hace
            //automaticamente, este llama a unintefazq que se llama Idisposable que llama a metodo dispose
            //finally bloc siempre seejecuta a menos que el proceso se dañe o falle, se puso stream.close;
            //catch es para atrapar la excepecion
            //con using creo un try finally no un try catch
            //muy probalmenten la excepcion se vea por consola System.FormatException
            //podemos poner varios try catch pero siempre poner los mas especificos y luego globales
            using (Stream stream = File.Create(SettingsFile))
            {
                //XML Serialization
                XmlSerializer ser = new XmlSerializer(this.GetType());
                ser.Serialize(stream, this);
            }     
        }

        public static MySettings Load()
        {
            if (!File.Exists(SettingsFile))
            {
                return DefaultSettings;
            }

            using (Stream stream = File.OpenRead(SettingsFile))
            {
               try
                {
                    XmlSerializer ser = new XmlSerializer(typeof(MySettings));
                    return (MySettings)ser.Deserialize(stream);
               }
                catch (InvalidOperationException)
                {
                    stream.Close();
                    File.Delete(SettingsFile);
                    return DefaultSettings;
                }
            }
        }

        private static string SettingsFolder
        {
            get
            {
                string folder = Environment.GetFolderPath(
                    Environment.SpecialFolder.ApplicationData);
                folder = Path.Combine(folder, "EX2OUTCODING");
                folder = Path.Combine(folder, "MyApp");
                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }
                return folder;
            }
        }

        private static string SettingsFile
        {
            get
            {
                return Path.Combine(SettingsFolder, "settings.xml");
            }
        }

        private static MySettings DefaultSettings
        {
            get
            {
                return new MySettings
                {
                    MyNumber = 0,
                    MyString = "",
                };
            }
        }
    }
}
