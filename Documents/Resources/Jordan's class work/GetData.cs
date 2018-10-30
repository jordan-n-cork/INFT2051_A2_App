

// Get all Events on a given date
public Event[] getEventsOnDate (string date) {

	return db.Query<Event>("SELECT * FROM Events WHERE Date = ?", date);

}

// Get all Events in a given Month and Year
public Event[] getAllEventsInMonth (string month, string year) {

	List<Event> events = new List<Event>();
	string date = "";

	for (int i = 1; i <= 31; i++) {

		if (i < 10)
			date = year + month + "0" + i;
		else 
			date = year + month + i;

		Event[] eventsOnDate = getEventsOnDate(date);

		for (int j = 0; j < eventsOnDate.Count; j++) {

			events.add(eventsOnDate[j]);

		}
	}

	return events;
}

