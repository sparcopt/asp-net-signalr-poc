namespace Server
{
    using Microsoft.Owin.Hosting;
    using System;

    internal class Program
    {
        public static void Main(string[] args)
        {
            var baseAddress = "http://localhost:9000/"; 
            
            using (WebApp.Start<Startup>(url: baseAddress)) 
            { 
                Console.ReadLine(); 
            } 
        }
    }
}