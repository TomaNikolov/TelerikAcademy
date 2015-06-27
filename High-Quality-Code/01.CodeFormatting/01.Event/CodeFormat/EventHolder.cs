namespace CodeFormat
{
    using System;
    using System.Text;
    using Wintellect.PowerCollections;

    public class EventHolder
    {
        private MultiDictionary<string, Event> groupByTitle;
        private OrderedBag<Event> groupByDate;
        private StringBuilder output;

        public EventHolder()
        {
            this.groupByTitle = new MultiDictionary<string, Event>(true);
            this.groupByDate = new OrderedBag<Event>();
            this.output = new StringBuilder();
        }

        public void AddEvent(DateTime date, string title, string location)
        {
            Event newEvent = new Event(date, title, location);
            this.groupByTitle.Add(title.ToLower(), newEvent);
            this.groupByDate.Add(newEvent);
            Messages.EventAdded(this.output);
        }

        public void DeleteEvents(string titleToDelete)
        {
            string title = titleToDelete.ToLower();
            int removed = 0;

            foreach (var eventToRemove in this.groupByTitle[title])
            {
                removed++;
                this.groupByDate.Remove(eventToRemove);
            }

            this.groupByTitle.Remove(title);
            Messages.EventDeleted(removed, this.output);
        }

        public void ListEvents(DateTime date, int count)
        {
            OrderedBag<Event>.View eventsToShow = this.groupByDate.RangeFrom(new Event(date, string.Empty, string.Empty), true);
            int showed = 0;

            foreach (var eventToShow in eventsToShow)
            {
                if (showed == count)
                {
                    break;
                }

                Messages.PrintEvent(eventToShow, this.output);

                showed++;
            }

            if (showed == 0)
            {
                Messages.NoEventsFound(this.output);
            }
        }

        public string AllMessages()
        {
            return this.output.ToString();
        }
    }
}
