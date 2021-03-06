﻿using Backend.Model;
using Frontend.App.Prompts;
using Frontend.Controller.Business;
using Frontend.View.Controller;
using Shared.Global;
using Shared.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Frontend.Controller.Prompts
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

            DateAndTime todaysDate = TimeAndDateUtility.ConvertDateTime_DateAndTime(today);
            DateAndTime start = TimeAndDateUtility.ConvertDateTime_DateAndTime(startDate);
            DateAndTime end = TimeAndDateUtility.ConvertDateTime_DateAndTime(endDate);

            List<SavedEvent> events = _eventController.GetEvents(start, end).ToList();
            List<ListViewItem> items = new List<ListViewItem>();

            events.ForEach(x =>
                {
                    string[] details = CalculateStatus(todaysDate, x, end);
                    string date = details[1];

                    ListViewItem item = new ListViewItem(details)
                    {
                        Group =
                            date.Contains(COMPLETED) ? groups["Complete"]
                                : (date.Contains(STARTS_IN) ? groups["Upcoming"]
                                    : (date.Contains(ENDS_IN) ? groups["HappeningNow"]
                                        : (date.Contains(OVERDUE_FROM) ? groups["Overdue"] : null)))
                    };

                    item.Tag = x.Id;
                    bool groupIsSet = item.Group != null && !string.IsNullOrEmpty(item.Group.Name);
                    if (groupIsSet)
                    {
                        string groupName = item.Group.Name;

                        int groupIndex = 
                            groupName == "Complete" ? 1
                                : groupName == "Upcoming" ? 2
                                    : groupName == "HappeningNow" ? 3
                                        : groupName == "Overdue" ? 4 : -1;

                        SetVisualDetails(groupIndex, item);
                        item.Tag = x.Id;
                    }

                    items.Add(item);
                }
            );

            return items.ToArray();
        }

        private void SetVisualDetails(int groupIndex, ListViewItem item)
        {
            switch (groupIndex)
            {
                case 2:
                    item.Font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);
                    item.ForeColor = Color.DarkSlateGray;
                    break;
                case 3:
                    item.Font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Italic);
                    item.ForeColor = Color.DarkSlateBlue;
                    break;
                case 4:
                    item.Font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Regular);
                    item.ForeColor = Color.DarkRed;
                    break;
                case 1:
                    item.Font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold | FontStyle.Italic);
                    item.ForeColor = Color.DarkGreen;
                    break;
                default:
                    break;
            }
        }

        private string[] CalculateStatus(DateAndTime start, SavedEvent @event, DateAndTime end)
        {
            (TimeSpan TimeDiff, DateCompare Comparison) diff =
                TimeAndDateUtility.ComputeDiff(start, (@event.ActivationDate, @event.DeactivationDate), end);

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

            return new string[] { @event.Title, resultString.Trim() };
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
        /// Gets all events between a specific range
        /// </summary>
        /// <param name="start">The start date</param>
        /// <param name="end">The end date</param>
        /// <param name="searchTerm">The term to search with</param>
        /// <returns>The list of saved events</returns>
        public object[] GetAll(DateAndTime start = null, DateAndTime end = null, string searchTerm = null)
        {
            return _eventController.GetEvents(start, end, searchTerm).Select(x => (object)x).Distinct().ToArray();
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
                EventCrudView form = new EventCrudView(_controls);
                form.CreateView(CrudPurposes.Create);

                form.ShowDialog();
                SavedEvent result = form.Data.Results;
                DialogResult dialogResult = form.Data.DialogResult;

                if (dialogResult != DialogResult.Cancel && result != null)
                {
                    added = _eventController.CreateEvent(result);
                }

                form.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to add item.", "Please try again.", MessageBoxButtons.OK);
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
                if (!string.IsNullOrEmpty(id))
                {
                    updated = _eventController.ToggleStatus(id);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to toggle item.", "Please try again.", MessageBoxButtons.OK);
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
                SavedEvent @event = _eventController.GetEvent(id);

                if (@event != null)
                {
                    EventCrudView form = new EventCrudView(_controls);
                    form.CreateView(CrudPurposes.Edit, @event);

                    form.ShowDialog();
                    SavedEvent result = form.Data.Results;
                    DialogResult dialogResult = form.Data.DialogResult;

                    if (dialogResult != DialogResult.Cancel && result != null)
                    {
                        result.Id = @event.Id;
                        updated = _eventController.EditEvent(result);
                    }

                    form.Dispose();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to update item.", "Please try again.", MessageBoxButtons.OK);
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

                if (!string.IsNullOrEmpty(title)) 
                {
                    DialogResult result =
                        MessageBox.Show($"Are you sure you want to remove event \"{title}\"?", $"Remove \"{title}\"", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        removed = _eventController.DeleteEvent(id);
                        MessageBox.Show($"\"{title}\" was removed successfully.", "Successful removal.", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to remove item.", "Please try again.", MessageBoxButtons.OK);
                removed = false;
            }

            return removed;
        }

        /// <summary>
        /// Loads events from save file
        /// </summary>
        /// <param name="overwrite">Whether to overwrite the current data</param>
        /// <returns>Whether the events were fully loaded</returns>
        public bool LoadEvents(bool overwrite = false)
        {
            return _eventController.LoadEvents(overwrite);
        }

        /// <summary>
        /// Loads events from sepcified save file
        /// </summary>
        /// <param name="path">The path to pull data from</param>
        /// <param name="overwrite">Whether to overwrite the current data</param>
        /// <returns>Whether the events were fully loaded</returns>
        public bool LoadEvents(string path, bool overwrite = false)
        {
            return _eventController.LoadEvents(path, overwrite);
        }

        /// <summary>
        /// Saves events to save file
        /// </summary>
        /// <returns>Whether the events were fully saved</returns>
        public bool SaveEvents()
        {
            return _eventController.SaveEvents();
        }

        /// <summary>
        /// Saves the events to a specified location
        /// </summary>
        /// <param name="path">The path to save the local data</param>
        /// <returns>Whether the events were fully saved</returns>
        public bool SaveEvents(string path)
        {
            return _eventController.SaveEvents(path);
        }
    }
}
