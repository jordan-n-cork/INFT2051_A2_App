using System;
using System.Collections.Generic;
using System.Text;

// ading the SQL 
using SQLite;

namespace A2_AppProject
{

    // Event.cs

    // Outlines the description of the Events Table
    // Stores all data relevent to an Event stored
    // by the Calendar including:
    // Id (incremented)
    // Style (Habit or To Do)
    // Description
    // Type 
    // Date (String in format '20180101')
    // Time (String in format '2359')
    // Alert Booleans
    // Boolean value used for each alert
    ////////// Better than using a list I think
    // Repeat Booleans
    // Boolean value used for each repeat
    ////////// Not sure how repeat will be implemented yet


    [Table("Events")]
    public class Event
    {

        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }

        [MaxLength(5)]
        public string Style { get; set; }

        [MaxLength(20)]
        public string Description { get; set; }

        [MaxLength(5)]
        public string Type { get; set; }

        [MaxLength(8)]
        public string Date { get; set; }

        [MaxLength(4)]
        public string Time { get; set; }

        public bool AllDay { get; set; }

        // Alert Booleans
        /*	un-commenting these as I add functionality 


        public string Location { get; set; }

        public bool AlertAtTime { get; set; }

        public bool Alert15 { get; set; }

        public bool Alert1hour { get; set; }

        public bool Alert2hours { get; set; }

        public bool Alert1day { get; set; }

        public bool Alert2days { get; set; }

        // Repeat Booleans
        public bool RepeatDay { get; set; }

        public bool RepeatWeek { get; set; }

        public bool RepeatFortnight { get; set; }

        public bool RepeatMonth { get; set; }

        public bool RepeatYear { get; set; }
        */

    }
}
