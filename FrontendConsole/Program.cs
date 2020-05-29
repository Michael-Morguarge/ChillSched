using ConsoleApp.Customize.Implementation;
using ConsoleApp.Customize.Interface;
using System;

namespace FrontendConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            ICustomConsoleColor menu = new SampleFormat();

            menu.DisplayText("Hello World!");
            menu.Actions();

            Console.WriteLine("\r\nGoodbye");
        }
    }
}
