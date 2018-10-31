using System;
using System.Collections.Generic;
using System.Text;

using System.IO;
using SQLite;

/*
* DataAccesss.cs
* 
* Class for use in Database Access and Mutation
*
* Database path: Environment.GetFolderPath(Environment.SpecialFolder.Personal
* Database Name: calendarDatabase.db3
* Tables:
*       - 'Events' - containing data of type Event
* 
* Methods:
*       - databaseAccessTest
*       - addEventToDataBase 
*       - getEventsOnDate
*       - getAllEventsInMonth
*
*/


namespace A2_AppProject
{
    static class DataAccess
    {
        /* 
         * Data Base Access Testing Method
         * 
         * Attempts to create a database, add an event and access the event
         * If all operations are successful event description will be displayed i.e. "This is an Event"
         * Else if an operation is unsuccessful and the event is not found
         * Then the displayed message will be "Database Access Failed"
        */  
        public static void databaseAccessTest()
        {
            // Get Database Connection
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "calendarDatabase.db3");
            var db = new SQLiteConnection(dbPath);
        
            // Add New Event to Database with date "20180101"
            // to add back in: , "", true, true, true, true, true, true
            addEventToDatabase("", "This is an event", "", "20180101", "", true);

            // Attempt to retrieve event by searching for events on date "20180101"
            List<Event> events = getEventsOnDate("20180101");

            if (events.Count > 0) // Event is found
            {
                // Display the Event Description
                string eventDescription = events[0].Description;
                // event result
                // var label2 = new Label { Text = eventDescription, TextDecorations = TextDecorations.Underline };
            }
            else // Event is not found
            {
                // result if data access failed 
                // will turn this into a DisplayAlert 
                //var label3 = new Label { Text = "Database Access Failed", TextDecorations = TextDecorations.Underline };
            }
        }
        
        
        /* 
         * Add an Event To Database
         * 
         * Parameters: Event Data
         * 
         * Creates a new Event
         * Sets the data to the parameter data 
         * Adds the new Event to the Database
        */  
        
        // to add back in: , string location, bool alertattime, bool alert15, bool alert1hour, bool alert2hours, bool alert1day, bool alert2days
        public static void addEventToDatabase(string style, string description, string type, string date, string time,
                                       bool allday)
        {
            // Get Database Connection
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "calendarDatabase.db3");
            var db = new SQLiteConnection(dbPath);

            Event evnt = new Event(); // Create new Event 
            
            // Set new Event Data to parameter data
            evnt.Style = style;
            evnt.Description = description;
            evnt.Type = type;
            evnt.Date = date;
            evnt.Time = time;
            evnt.AllDay = allday;
                    /* too uncomment later when figured out functionality 
                    evnt.Location = location;
                    evnt.AlertAtTime = alertattime;
                    evnt.Alert15 = alert15;
                    evnt.Alert1day = alert1day;
                    evnt.Alert1hour = alert1hour;
                    evnt.Alert2days = alert2days;
                    evnt.Alert2hours = alert2hours;
                    */

            // Add new Event to Database in Event Table
            db.CreateTable<Event>();
            db.Insert(evnt);

        }

        /*
         * Get All Events on a Given Date
         *
         * Queries database for Events on the date passed in as a parameter (string)
         * Returns List of Events on that date
         *
         * Date Format: "YYYYMMDD"
         * 
        */
        public static List<Event> getEventsOnDate(string date)
        {
            // Get Database Connection
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "calendarDatabase.db3");
            var db = new SQLiteConnection(dbPath);

            // Query Database for Events on the date (string) parameter
            return db.Query<Event>("SELECT * FROM Events WHERE Date = ?", date);

        }


        /*
         * Get All Events on a Given Month and Year
         *
         * Queries database for Events on the Month and Year passed in as parameters (strings)
         * Returns List of Events on all the dates in that month
         * i.e. Month: Oct, Year: 2018
         * Returns Events on Dates from 1st Oct 2018 to the 31st Oct 2018
         *
         * Month Format: "MM"
         * Year Format: "YYYY"
         * 
        */
        public static List<Event> getAllEventsInMonth(string month, string year)
        {
            // Create list to store found Events
            List<Event> events = new List<Event>();
            string date = "";

            // Increment over all days in Month
            for (int i = 1; i <= 31; i++)
            {
                // Format Date String
                if (i < 10)
                    date = year + month + "0" + i;
                else
                    date = year + month + i;
                
                // Search for Events on Date
                List<Event> eventsOnDate = getEventsOnDate(date);

                // Add all Events found on date to Events list
                for (int j = 0; j < eventsOnDate.Count; j++)
                {
                    events.Add(eventsOnDate[j]);

                }
            }
            // Return all Events found in Month/Year
            return events;
        }
    }
}
