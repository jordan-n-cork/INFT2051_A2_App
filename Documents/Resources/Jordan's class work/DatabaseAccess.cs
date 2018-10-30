using System;
using SQLite;
using System.IO;
using System.Collections.Generic;
using Xamarin.Forms;

namespace A2_AppProject
{
    public static class DatabaseAccess
    {

        public static void databaseAccessTest()
        {

            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "calendarDatabase.db3");
            var db = new SQLiteConnection(dbPath);

            addEventToDatabase("", "This is an event", "", "20180101", "", true, "", true, true,
                               true, true, true, true);

            List<Event> events = getEventsOnDate("20180101");

            if (events.Count > 0)
            {
                string eventDescription = events[0].Description;
                var label2 = new Label { Text = eventDescription, TextDecorations = TextDecorations.Underline };
            }
            else
            {
                var label3 = new Label { Text = "Database Access Failed", TextDecorations = TextDecorations.Underline };
            }
        }

        public static void addEventToDatabase(string style, string description, string type, string date, string time,
                                       bool allday, string location, bool alertattime, bool alert15, bool alert1hour,
                                        bool alert2hours, bool alert1day, bool alert2days)
        {

            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "calendarDatabase.db3");
            var db = new SQLiteConnection(dbPath);

            Event evnt = new Event();
            evnt.Style = style;
            evnt.Description = description;
            evnt.Type = type;
            evnt.Date = date;
            evnt.Time = time;
            evnt.AllDay = allday;
            evnt.Location = location;
            evnt.AlertAtTime = alertattime;
            evnt.Alert15 = alert15;
            evnt.Alert1day = alert1day;
            evnt.Alert1hour = alert1hour;
            evnt.Alert2days = alert2days;
            evnt.Alert2hours = alert2hours;

            db.CreateTable<Event>();
            db.Insert(evnt);

        }

        // Get all Events on a given date
        public static List<Event> getEventsOnDate(string date)
        {
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "calendarDatabase.db3");
            var db = new SQLiteConnection(dbPath);

            return db.Query<Event>("SELECT * FROM Events WHERE Date = ?", date);

        }


        // Get all Events in a given Month and Year
        public static List<Event> getAllEventsInMonth(string month, string year)
        {

            List<Event> events = new List<Event>();
            string date = "";

            for (int i = 1; i <= 31; i++)
            {

                if (i < 10)
                    date = year + month + "0" + i;
                else
                    date = year + month + i;

                List<Event> eventsOnDate = getEventsOnDate(date);

                for (int j = 0; j < eventsOnDate.Count; j++)
                {
                    events.Add(eventsOnDate[j]);

                }
            }

            return events;
        }
    }
}
