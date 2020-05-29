using ConsoleApp.Customize.Interface;
using System;

namespace FrontendConsole.Implementation
{
    public class StartMenuFormat : ICustomConsoleColor
    {
        public string NoContentMessage { get; set; }

        public string Content { get; set; }

        public void DisplayText(string header)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine(header);

            Console.ResetColor();

            Console.WriteLine(string.IsNullOrEmpty(Content) ? NoContentMessage : Content);
        }

        public void Actions()
        {
            throw new System.NotImplementedException();
            //Events Menu, Messages Menu, Export Menu, About, Close

            //Events Menu: Month-At-A-Glance, View Specific Day, View All, Search Events, Create Event
            // //Month-At-A-Glance: Select Event, View Another Month, Refresh List
            // //View Specific Day: Select Event, View Another Day, Refresh List
            // //View All: Select event, Refresh List
            // //Search Events: Select Event, Modify Search
            // //Create Event: (Creates an event. [something to exit])
        }
    }
}
