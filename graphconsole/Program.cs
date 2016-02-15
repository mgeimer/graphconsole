using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;  //for the http requests
using System.Net;
using Microsoft.IdentityModel.Clients.ActiveDirectory; //for ADAL auth.

namespace graphconsole
{
    class Program
    {

        //set up our variables needed for auth
        string clientID, clientSecret;
        AuthenticationContext authContext = new AuthenticationContext("https://login.microsoftonline.com/PUTTENANTHERE");

        static void Main(string[] args)
        {
            string URL = args[0];
            WebRequest request = WebRequest.Create(URL);
            Stream response = request.GetResponse().GetResponseStream();
            StreamReader readresponse = new StreamReader(response);
            string line = "";
            int i = 0;
            while (line != null)
            {
                i++;
                line = readresponse.ReadLine();
                if (line != null) Console.WriteLine(line);
            }
        }
    }
}
