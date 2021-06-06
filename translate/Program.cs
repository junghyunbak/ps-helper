using libMessage;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace translate
{
    static class Program
    {
        /*
        args[0] : message
        args[1] : translate language inverse or reverse 
        */
        [STAThread]
        static void Main(string[] args)
        {
            string[] language = { "ko", "en" };
            string[] spstring = { };
            string resourcePath = Directory.GetParent(Application.StartupPath).FullName + "\\res\\";
            string filePath = resourcePath + "data.txt";
            if (File.Exists(filePath))
            {
                StreamReader sr = new StreamReader(new FileStream(
                    filePath,
                    FileMode.Open
                    )
                );
                spstring = sr.ReadLine().Split(' ');
                sr.Close();
            }
            string url = "https://openapi.naver.com/v1/papago/n2mt";
            string clientId = "nNqf9qWgG6CR_jkQzoGN";
            string clientSecret = "csoFEi5jWi";
            string query = args[0];
            string source = language[int.Parse(spstring[3])];
            string target = language[int.Parse(spstring[4])];
            if (args[1] == "r")
            {
                string tmp;
                tmp = source;
                source = target;
                target = tmp;
            }
            Console.WriteLine(source + " to " + target);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Headers.Add("X-Naver-Client-Id", clientId);
            request.Headers.Add("X-Naver-Client-Secret", clientSecret);
            request.Method = "POST";
            byte[] byteDataParams = Encoding.UTF8.GetBytes(
                "source=" + source
                + "&target=" + target
                + "&text=" + query
                );
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = byteDataParams.Length;
            Stream st = request.GetRequestStream();
            st.Write(byteDataParams, 0, byteDataParams.Length);
            st.Close();
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream, Encoding.UTF8);
            string text = reader.ReadToEnd();
            stream.Close();
            response.Close();
            reader.Close();
            JObject jObject = JObject.Parse(text);
            Send post = new Send();
            post.sendMessage("t|" + jObject["message"]["result"]["translatedText"].ToString());
        }
    }
}
