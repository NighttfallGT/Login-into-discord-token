using System;
using OpenQA.Selenium.Chrome;

namespace TokenLogin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "TokenLogin | by deep1dark";
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("Token: ");
            Console.ForegroundColor = ConsoleColor.White;
            string token = Console.ReadLine();
            Console.Clear();
            ChromeDriver chrome = new ChromeDriver();
            chrome.Navigate().GoToUrl("https://discord.com/login");
            try
            {
                chrome.ExecuteScript("function login(token) {setInterval(() => {document.body.appendChild(document.createElement `iframe`).contentWindow.localStorage.token = `\"${token}\"`}, 50);setTimeout(() => {location.reload();}, 0);} login(\"" + token + "\")");
                Console.Clear();
            }
            catch
            {
                Console.WriteLine("Error");
            }
        }
    }
}
