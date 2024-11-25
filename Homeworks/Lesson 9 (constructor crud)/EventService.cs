using Lesson_9.Models;
namespace Lesson_9.Services;

public class EventService
{
    private List<Event> events;
    public EventService()
    {
        events = new List<Event>();
    }
    public Event AddEvent(Event newEvent)
    {
        newEvent.Id = Guid.NewGuid();
        events.Add(newEvent);
        return newEvent;
    }
    public bool DeleteEvent(Guid eventId)
    {
        var exists = false;
        foreach (var newEvent in events)
        {
            if (newEvent.Id == eventId)
            {
                events.Remove(newEvent);
                exists = true;
                break;
            }
        }
        return exists;
    }
    public bool UpdateEvents(Event upgratedEvent)
    {
        for (var i = 0; i < events.Count; i++)
        {
            if (events[i].Id == upgratedEvent.Id)
            {
                events[i] = upgratedEvent;
                return true;
            }
        }
        return false;
    }
    public Event GetById(Guid eventId)
    {
        foreach (var allEvent in events)
        {
            if (allEvent.Id == eventId)
            {
                return allEvent;
            }
        }
        return null;
    }
    public List<Event> GetAllEvent()
    {
        return events;
    }
    public List<Event> GetEventsByLocation(string location)
    {
        var situationByLocation = new List<Event>();
        foreach (var situation in events)
        {
            if (situation.Location == location)
            {
                situationByLocation.Add(situation);
            }
        }
        return situationByLocation;
    }
    public Event GetPopularEvent()
    {
        var popularEvent = new Event();
        foreach (var eventvisitor in events)
        {
            if (eventvisitor.Attendees.Count > popularEvent.Attendees.Count)
            {
                popularEvent = eventvisitor;
            }
        }
        return popularEvent;
    }
    public Event GetMaxTaggedEvent()
    {
        var maxTaggedEvent = new Event();
        foreach (var eventvisitor in events)
        {
            if (eventvisitor.Attendees.Count > maxTaggedEvent.Attendees.Count)
            {
                maxTaggedEvent = eventvisitor;
            }
        }
        return maxTaggedEvent;
    }
   public bool AddPersonToEvent(Guid Id , string person)
    {
        var existsEvent = GetById(Id);
        if (existsEvent == null)
        {
            return false;
        }
        existsEvent.Attendees.Add(person);
        return true;
    }
}
  


