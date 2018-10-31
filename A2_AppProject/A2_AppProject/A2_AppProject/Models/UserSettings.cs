using System;
using System.Collections.Generic;
using System.Text;

using SQLite;

namespace A2_AppProject
{
    [Table("UserSettings")]
    public class UserSettings 
    {
        // will hopefully help with setting TodayView
        [MaxLength(4)]
        public string StartTime { get; set; }

        [MaxLength(4)]
        public string EndTime { get; set; }
    }
}
