using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace ProyectoF
{
    public class Save
    {
        public static void SaveData(object obj, string Filename) {

            XmlSerializer sr = new XmlSerializer(obj.GetType());
            TextWriter wr = new StreamWriter(Filename);
            sr.Serialize(wr, obj);
            wr.Close();
        
        }//SaveData
      

    }
}
