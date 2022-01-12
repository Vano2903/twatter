using System;
using System.Collections.Generic;
using System.IO;

namespace twatter
{
    class webServer
    {
        public int OK = 200;
        public int CREATED = 201;
        public int ACCEPTED = 202;
        public int TERMPORARY_REDIRECT = 307;
        public int BAD_REQUEST = 400;
        public int UNAUTHORIZED = 401;
        public int FORBIDDEN = 403;
        public int NOT_FOUND = 404;
        public int METHOD_NOT_ALLOWED = 405;
        public int NOT_ACCPETABLE = 406;
        public int CONFLICT = 409;
        public int PAYLOAD_TOO_LARGE = 413;
        public int INTERNAL_SERVER_ERROR = 500;
        public int NOT_IMPLEMENTED = 501;

        private Dictionary<string, string> pages;
        private string ip;
        private int port;

        public webServer( string ip, int port)
        {
            this.pages = new Dictionary<string, string>();
            this.ip = ip;
            this.port = port;
        }

        public void init()
        {
            string[] pages = { "home.html" };
            string[] indexes = { "home" };
            int i = 0;
            foreach (string page in pages)
            {
                string readText = File.ReadAllText("./pages/"+page);
                this.pages.Add(indexes[i], readText);
                i++;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
