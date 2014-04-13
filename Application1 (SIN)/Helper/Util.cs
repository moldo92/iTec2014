using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Helper
{
    [Serializable]
    public static class Util
    {
        public enum ROLE
        {
            ADMIN,
            USER
        }

        public static Dictionary<string, string> LoadXml()
        {
            var dic = new Dictionary<string, string>();
            var document = new XmlDocument();
            document.Load("settings.xml");
            var root = document.DocumentElement;

            //connection
            XmlNodeList mysql = root.SelectNodes("//Settings/Conn");
            foreach (XmlNode i in mysql)
            {
                foreach (XmlNode j in i.ChildNodes)
                {
                    dic.Add(j.Name, j.InnerText);
                }
            }
            return dic;
        }
    }
}
