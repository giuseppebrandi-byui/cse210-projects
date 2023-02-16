using System;

public class EventsList
{
    private List<Event> _eventsList;
    private int numberOfReceptions = 3;
    private int numberOfOutdoor = 1;
    private int numberOfLectures = 1;

    public EventsList()
    {
        // Create a list of event titles
        List<string> eventTitlesList = new List<string>
        {
            "Lindy Fridays",
            "Leeds People's Choir",
            "Kuluhenna Drama Workshops",
            "Makers Lab",
            "The Positive Awards"
        };

        // Create a list of event descriptions
        List<string> eventDescriptionList = new List<string>
        {
            "Friendly drop in lindy hop class. Complete beginners welcome. Come along and learn this dynamic African-American dance style, dance to swinging tunes "
            + "from the 30s and 40s, and make new friends. All are welcome! No partner required!",
            "Leeds People's Choir is friendly group of people brought together by a shared love of music and singing.",
            "Join Mafwa's free weekly drama sessions for women in Leeds to make new friends, learn skills and get creative.",
            "Experiment with paint, clay, food and other exciting new materials and techniques for making art.",
            "The 4th annual Positive Awards supported by Liverpool Lifestyle magazine."
        };

        // Create a list of event dates
        List<string> eventDatesList = new List<string>
        {
            "28th July 2023",
            "19th July 2023",
            "2nd March 2023",
            "30th September 2023",
            "1st April 2023"
        };

        // Create a list of event times
        List<string> eventTimesList = new List<string>
        {
            "9:00am",
            "7:00pm",
            "10:30am",
            "11:00am",
            "7:00pm"
        };

        // Create a list of event types
        List<string> eventTypesList = new List<string>
        {
            "Reception",
            "Reception",
            "Reception",
            "Outdoor",
            "Lecture"
        };

        // Create a list of event Speakers
        List<string> eventSpeakersList = new List<string>
        {
            "N/A",
            "N/A",
            "N/A",
            "N/A",
            "John Smith Jr."
        };

        // Create a list of contact e-mails
        List<string> eventEmailsList = new List<string>
        {
            "info@electricpress.co.uk",
            "leedspeopleschoir@gmail.com",
            "info@mafwatheatre.co.uk",
            "info@the_tetley.co.uk",
            "info@awards.com"
        };

        // Create a list of capactity for the venu
        List<int> eventCapacityList = new List<int>
        {
            200,
            350,
            275,
            300,
            500
        };

        // Create a list of weather statements
        List<string> eventWeatherStatementsList = new List<string>
        {
            "Scattered Clouds",
            "Rain",
            "Rain",
            "Sunny",
            "Sunny"
        };

        // Create a list of streets
        List<string> streetsList = new List<string>
        {
            "Carriageworks Theatre, 3 Millenium Square",
            "Swarthmore Education Centre, 2-7 Woodhouse Square",
            "East Street Arts",
            "The Tetley, Hunslet Road",
            "Hilton Hotel, Lord Nelson St"
        };

        // Create a list of cities
        List<string> citiesList = new List<string>
        {
            "Leeds",
            "Leeds",
            "Manchester",
            "Leeds",
            "Liverpool"
        };

        // Create a list of post codes
        List<string> postCodesList = new List<string>
        {
            "LS2 3AD",
            "LS3 1AD",
            "M4 1LG",
            "LS10 1JQ",
            "L3 5QB"
        };

        // Create an event list
        _eventsList = new List<Event>();
        // Set the number of events to zero
        int numberOfEvents = 0;

        // Loop through the number of receptions
        for (int i = 0; i < numberOfReceptions; i++)
        {
            // Add the reception event details to the event list
            _eventsList.Add(new Reception(eventTitlesList[i], eventDescriptionList[i],
                eventDatesList[i], eventTimesList[i],
                new Address(streetsList[i], citiesList[i], postCodesList[i]),
                eventTypesList[i], eventEmailsList[i]));
        }

        // Increment the number of events by the number of receptions
        numberOfEvents += numberOfReceptions;

        // Loop through the number of outdoor events
        for (int i = numberOfEvents; i < numberOfEvents + numberOfOutdoor; i++)
        {
            _eventsList.Add(new Outdoor(eventTitlesList[i], eventDescriptionList[i],
                eventDatesList[i], eventTimesList[i],
                new Address(streetsList[i], citiesList[i], postCodesList[i]),
                eventTypesList[i], eventWeatherStatementsList[i]));
        }

        // Increment the number of events by the number of outdoot events
        numberOfEvents += numberOfOutdoor;

        // Loop through the number of lecture events
        for (int i = numberOfEvents; i < numberOfEvents + numberOfLectures; i++)
        {
            _eventsList.Add(new Lecture(eventTitlesList[i], eventDescriptionList[i],
                eventDatesList[i], eventTimesList[i],
                new Address(streetsList[i], citiesList[i], postCodesList[i]),
                eventTypesList[i], eventSpeakersList[i], eventCapacityList[i]));
        }

    }

    // Generate Standard Details
    public string GenerateStandardDetails()
    {
        string standardDetails = "|| STANDARD EVENT DETAILS ||\n\n";
        // Generate Standard Details
        foreach (Event event_ in _eventsList)
        {
            standardDetails += $"{event_.GenerateStandardDetails()}\n";
        }
        return standardDetails;

    }

    // Generate Full Details
    public string GenerateFullDetails()
    {
        string fullDetails = "|| FULL EVENT DETAILS ||\n\n";
        int numberOfEvents = 0;

        for (int i = numberOfEvents; i < numberOfReceptions; i++)
        {
            fullDetails += ((Reception)_eventsList[i]).GenerateFullDetails();
        }

        numberOfEvents += numberOfReceptions;

        for (int i = numberOfEvents; i < numberOfEvents + numberOfOutdoor; i++)
        {
            fullDetails += ((Outdoor)_eventsList[i]).GenerateFullDetails();
        }

        numberOfEvents += numberOfOutdoor;

        for (int i = numberOfEvents; i < numberOfEvents + numberOfLectures; i++)
        {
            fullDetails += ((Lecture)_eventsList[i]).GenerateFullDetails();
        }
        return fullDetails;

    }

    // Generate Short Details
    public string GenerateShortDetails()
    {
        string shortDetails = "|| SHORT EVENT DETAILS ||\n\n";
        foreach (Event event_ in _eventsList)
        {
            shortDetails += $"{event_.GenerateShortDetails()}\n";
        }
        return shortDetails;

    }
}