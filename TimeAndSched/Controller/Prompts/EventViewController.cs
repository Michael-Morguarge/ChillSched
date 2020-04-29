using Backend.Model;
using FrontEnd.App.Views;
using FrontEnd.View.Controller;
using Shared.Global;
using Shared.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FrontEnd.Controller.Prompts
{
    /// <summary>
    /// Controller for Events View
    /// </summary>
    public class EventViewController
    {
        private readonly EventController _eventController;
        private readonly ControlsAccess _controls;

        private const string COMPLETED = "Completed";
        private const string STARTS_IN = "Starts in ";
        private const string ENDS_IN = "Ends in ";
        private const string OVERDUE_FROM = "Overdue from ";

        /// <summary>
        /// Constructor for Event View
        /// </summary>
        /// <param name="controls">The controls to manage</param>
        public EventViewController(ControlsAccess controls)
        {
            _eventController = new EventController();
            _controls = controls;
        }

        /// <summary>
        /// Gets all the items for the mothly glance list view
        /// </summary>
        /// <param name="groups">The groups to categorize events</param>
        /// <returns>The list of ListViewItem to display</returns>
        public ListViewItem[] GetAll(ListViewGroupCollection groups)
        {
            DateTime today = DateTime.Now;
            int maxDay = DateTime.DaysInMonth(today.Year, today.Month);
            DateTime startDate = today.AddDays(-(today.Day - 1));
            DateTime endDate = today.AddDays(maxDay - today.Day).AddHours(23 - today.Hour).AddMinutes(59 - today.Minute).AddSeconds(59 - today.Second);

            Date todaysDate = TimeAndDateUtility.ConvertDate_Date(today);
            Time todaysTime = TimeAndDateUtility.ConvertTime_Time(today);
            Date start = TimeAndDateUtility.ConvertDate_Date(startDate);
            Date end = TimeAndDateUtility.ConvertDate_Date(endDate);
            Time endTime = TimeAndDateUtility.ConvertTime_Time(endDate);

            List<SavedEvent> events = _eventController.GetEvents(start, end).ToList();
            List<ListViewItem> items = new List<ListViewItem>();

            events.ForEach(x =>
                {
                    string[] details = CalculateStatus(todaysDate, todaysTime, x, end, endTime);
                    string date = details[1];
                    ListViewItem item = new ListViewItem(details)
                    {
                        Group =
                            date.Contains(COMPLETED) ? groups["Complete"]
                                : (date.Contains(STARTS_IN) ? groups["Upcoming"]
                                    : (date.Contains(ENDS_IN) ? groups["HappeningNow"]
                                        : (date.Contains(OVERDUE_FROM) ? groups["Overdue"] : null)))
                    };

                    items.Add(item);
                }
            );

            return items.ToArray();
        }

        private string[] CalculateStatus(Date start, Time startTime, SavedEvent @event, Date end, Time endTime)
        {
            (TimeSpan TimeDiff, DateCompare Comparison) diff =
                TimeAndDateUtility.ComputeDiff(
                    (start, startTime),
                    (@event.ActivationDate, @event.ActivationTime, @event.DeactivationDate, @event.DeactivationTime),
                    (end, endTime)
                );


            DateCompare comparison = diff.Comparison;
            string template = string.Empty;

            if (@event.Completed)
            {
                template = COMPLETED;
            }
            else if (comparison == DateCompare.Before)
            {
                template = STARTS_IN;
            }
            else if (comparison == DateCompare.During)
            {
                template = ENDS_IN;
            }
            else if (comparison == DateCompare.After)
            {
                template = OVERDUE_FROM;
            }

            TimeSpan span = diff.TimeDiff;

            string days = $"{span.Days}D";
            string hours = $"{span.Hours}H";
            string mins = $"{span.Minutes}M";
            string secs = $"{span.Seconds}S";

            string resultString =
                template == COMPLETED ?
                    template 
                    : template
                        + (span.Days > 0 ? days + " " : string.Empty)
                        + (span.Hours > 0 ? hours + " " : string.Empty)
                        + (span.Minutes > 0 ? mins + " " : string.Empty)
                        + (span.Seconds > 0 ? secs : string.Empty);

            return new string[] { @event.Title, resultString };
        }

        /// <summary>
        /// Gets all the dates that have an event
        /// </summary>
        /// <returns>A list of dates where events occur</returns>
        public DateTime[] GetAllEventDates()
        {
            return _eventController.GetAllEventDates().ToArray();
        }

        /// <summary>
        /// Gets all the events on a specific date
        /// </summary>
        /// <param name="date">The date to search with</param>
        /// <returns></returns>
        public object[] GetAll(Date date)
        {
            return _eventController.GetEvents(date).Select(x => (object)x).Distinct().ToArray();
        }

        /// <summary>
        /// Gets an event
        /// </summary>
        /// <param name="id">The id of the event</param>
        /// <returns>The details of the event</returns>
        public SavedEvent GetEvent(string id)
        {
            return _eventController.GetEvent(id);
        }

        /// <summary>
        /// Adds and event
        /// </summary>
        /// <returns>Whether the event was added</returns>
        public bool Add()
        {
            bool added = false;

            try
            {
                GeneralForm form = new GeneralForm(_controls);
                form.CreateView(CrudPurposes.Create);

                form.ShowDialog();
                SavedEvent result = form.Results;
                DialogResult dialogResult = form.PromptResult;

                if (dialogResult != DialogResult.Cancel && result != null)
                {
                    added = _eventController.CreateEvent(result);
                }

                form.Dispose();
            }
            catch (Exception)
            {
                added = false;
            }

            return added;
        }

        /// <summary>
        /// Toggles an event's completion status
        /// </summary>
        /// <param name="id">The id of the event</param>
        /// <returns>Whether the event was updated</returns>
        public bool ToggleStatus(string id)
        {
            bool updated = false;

            try
            {
                updated = _eventController.ToggleStatus(id);
            }
            catch (Exception)
            {
                updated = false;
            }

            return updated;
        }

        /// <summary>
        /// Updates an event
        /// </summary>
        /// <param name="id">The id of the event</param>
        /// <returns>Whether the event was updated</returns>
        public bool Update(string id)
        {
            bool updated = false;

            try
            {
                GeneralForm form = new GeneralForm(_controls);
                SavedEvent @event = _eventController.GetEvent(id);
                form.CreateView(CrudPurposes.Edit, @event);

                form.ShowDialog();
                SavedEvent result = form.Results;
                DialogResult dialogResult = form.PromptResult;

                if (dialogResult != DialogResult.Cancel && result != null)
                {
                    result.Id = id;
                    updated = _eventController.EditEvent(result);
                }

                form.Dispose();
            }
            catch (Exception) {
                updated = false;
            }

            return updated;
        }

        /// <summary>
        /// Removes an event
        /// </summary>
        /// <param name="id">The id of the event</param>
        /// <returns>Whether the event was removed</returns>
        public bool Remove(string id)
        {
            bool removed = false;

            try
            {
                string title = _eventController.GetEvent(id)?.Title;
                DialogResult result =
                    MessageBox.Show($"Are you sure you want to remove event \"{title}\"?", $"Remove {title}", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    removed = _eventController.DeleteEvent(id);
                    MessageBox.Show($"\"{title}\" was removed successfully.", "Successful removal.", MessageBoxButtons.OK);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to remove item.", "Please try again.", MessageBoxButtons.OK);
                removed = false;
            }

            return removed;
        }

        public void LoadEvents()
        {
            _eventController.LoadEvents();
        }

        public void SaveEvents()
        {
            _eventController.SaveEvents();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
