using System.Collections.Generic;

namespace ElStudent.DB
{
    internal class SessionManager
    {
        private static Dictionary<string, string> sessionData = new Dictionary<string, string>();
        public void SetSessionData(string key, string value)
        {
            if (sessionData.ContainsKey(key))
            {
                sessionData[key] = value;
            }
            else
            {
                sessionData.Add(key, value);
            }
        }
        public string GetSessionData(string key)
        {
            if (sessionData.ContainsKey(key))
            {
                return sessionData[key];
            }
            else
            {
                return default;
            }
        }
    }
}
