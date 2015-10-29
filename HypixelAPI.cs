using System;
using System.Text;
using System.Net;
using System.IO;
using System.Windows.Forms;

namespace HypixelAPI
{
    class HypixelAPI
    {

        private static string BASE_URL = "https://api.hypixel.net/";
        private static string API_KEY = "########-####-####-####-############";

        public static string getPlayerByUuid(string uuid)
        {
            string reply = null;
            // https://api.hypixel.net/player?key=<api_key>&uuid=<uuid>
            string url = BASE_URL + "player?key=" + API_KEY + "&uuid=" + uuid;
            WebResponse response = null;
            StreamReader reader = null;

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";
                response = request.GetResponse();
                reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                reply = reader.ReadToEnd();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                if (response != null)
                    response.Close();
            }

            return reply;
        }

        public static string getPlayerByPlayer(string player)
        {
            string reply = null;
            // https://api.hypixel.net/player?key=<api_key>&player=<player>
            string url = BASE_URL + "player?key=" + API_KEY + "&player=" + player;
            WebResponse response = null;
            StreamReader reader = null;

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";
                response = request.GetResponse();
                reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                reply = reader.ReadToEnd();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                if (response != null)
                    response.Close();
            }

            return reply;
        }

        public static string getPlayerByName(string name)
        {
            string reply = null;
            // https://api.hypixel.net/player?key=<api_key>&name=<name>
            string url = BASE_URL + "player?key=" + API_KEY + "&name=" + name;
            WebResponse response = null;
            StreamReader reader = null;

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";
                response = request.GetResponse();
                reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                reply = reader.ReadToEnd();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                if (response != null)
                    response.Close();
            }

            return reply;
        }

        public static string getFriendsByUuid(string uuid)
        {
            string reply = null;
            // https://api.hypixel.net/friends?key=<api_key>&uuid=<uuid>
            string url = BASE_URL + "friends?key=" + API_KEY + "&uuid=" + uuid;
            WebResponse response = null;
            StreamReader reader = null;

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";
                response = request.GetResponse();
                reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                reply = reader.ReadToEnd();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                if (response != null)
                    response.Close();
            }

            return reply;
        }

        public static string getFriendsByPlayer(string player)
        {
            string reply = null;
            // https://api.hypixel.net/friends?key=<api_key>&player=<player>
            string url = BASE_URL + "friends?key=" + API_KEY + "&player=" + player;
            WebResponse response = null;
            StreamReader reader = null;

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";
                response = request.GetResponse();
                reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                reply = reader.ReadToEnd();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                if (response != null)
                    response.Close();
            }

            return reply;
        }

        public static string getFriendsByName(string name)
        {
            string reply = null;
            // https://api.hypixel.net/friends?key=<api_key>&name=<name>
            string url = BASE_URL + "friends?key=" + API_KEY + "&name=" + name;
            WebResponse response = null;
            StreamReader reader = null;

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";
                response = request.GetResponse();
                reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                reply = reader.ReadToEnd();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                if (response != null)
                    response.Close();
            }

            return reply;
        }

        public static string getGuildInfo(string id)
        {
            string reply = null;
            // https://api.hypixel.net/guild?key=<api_key>&id=<id>
            string url = BASE_URL + "guild?key=" + API_KEY + "&id=" + id;
            WebResponse response = null;
            StreamReader reader = null;

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";
                response = request.GetResponse();
                reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                reply = reader.ReadToEnd();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                if (response != null)
                    response.Close();
            }

            return reply;
        }

        public static string findGuildByUuid(string uuid)
        {
            string reply = null;
            // https://api.hypixel.net/findGuild?key=<api_key>&byUuid=<uuid>
            string url = BASE_URL + "findGuild?key=" + API_KEY + "byUuid" + uuid;
            WebResponse response = null;
            StreamReader reader = null;

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";
                response = request.GetResponse();
                reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                reply = reader.ReadToEnd();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                if (response != null)
                    response.Close();
            }

            return reply;
        }

        public static string findGuildByPlayer(string player)
        {
            string reply = null;
            // https://api.hypixel.net/findGuild?key=<api_key>&byPlayer=<player>
            string url = BASE_URL + "findGuild?key=" + API_KEY + "&byPlayer=" + player;
            WebResponse response = null;
            StreamReader reader = null;

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";
                response = request.GetResponse();
                reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                reply = reader.ReadToEnd();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                if (response != null)
                    response.Close();
            }

            return reply;
        }

        public static string findGuildByName(string name)
        {
            string reply = null;
            // https://api.hypixel.net/findGuild?key=<api_key>&byName=<name>
            string url = BASE_URL + "findGuild?key=" + API_KEY + "&byName=" + name;
            WebResponse response = null;
            StreamReader reader = null;

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";
                response = request.GetResponse();
                reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                reply = reader.ReadToEnd();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                if (response != null)
                    response.Close();
            }

            return reply;
        }

        public static string getSessionByUuid(string uuid)
        {
            string reply = null;
            // https://api.hypixel.net/session?key=<api_key>&uuid=<uuid>
            string url = BASE_URL + "session?key=" + API_KEY + "&uuid=" + uuid;
            WebResponse response = null;
            StreamReader reader = null;

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";
                response = request.GetResponse();
                reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                reply = reader.ReadToEnd();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                if (response != null)
                    response.Close();
            }

            return reply;
        }

        public static string getSessionByPlayer(string player)
        {
            string reply = null;
            // https://api.hypixel.net/session?key=<api_key>&player=<player>
            string url = BASE_URL + "session?key=" + API_KEY + "&player=" + player;
            WebResponse response = null;
            StreamReader reader = null;

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";
                response = request.GetResponse();
                reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                reply = reader.ReadToEnd();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                if (response != null)
                    response.Close();
            }

            return reply;
        }

        public static string getSessionByName(string name)
        {
            string reply = null;
            // https://api.hypixel.net/session?key=<api_key>&name=<name>
            string url = BASE_URL + "session?key=" + API_KEY + "&name=" + name;
            WebResponse response = null;
            StreamReader reader = null;

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";
                response = request.GetResponse();
                reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                reply = reader.ReadToEnd();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                if (response != null)
                    response.Close();
            }

            return reply;
        }

        public static string getBoosters()
        {
            string reply = null;
            // https://api.hypixel.net/boosters?key=<api_key>
            string url = BASE_URL + "boosters?key=" + API_KEY;
            WebResponse response = null;
            StreamReader reader = null;

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";
                response = request.GetResponse();
                reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                reply = reader.ReadToEnd();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                if (response != null)
                    response.Close();
            }

            return reply;
        }

        public static string getKeyInfo()
        {
            string reply = null;
            // https://api.hypixel.net/key?key=<api_key>
            string url = BASE_URL + "key?key=" + API_KEY;
            WebResponse response = null;
            StreamReader reader = null;

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";
                response = request.GetResponse();
                reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                reply = reader.ReadToEnd();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                if (response != null)
                    response.Close();
            }

            return reply;
        }

        public static string getKeyInfo(string key)
        {
            string reply = null;
            // https://api.hypixel.net/key?key=<api_key>
            string url = BASE_URL + "key?key=" + key;
            WebResponse response = null;
            StreamReader reader = null;

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";
                response = request.GetResponse();
                reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                reply = reader.ReadToEnd();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                if (response != null)
                    response.Close();
            }

            return reply;
        }

    }
}
