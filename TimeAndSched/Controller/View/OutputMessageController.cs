using Backend.Model;
using Shared.Utility;
using FrontEnd.App.Index.Views;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using FrontEnd.App.Index.Implementations;
using System;
using SharedItems.Abstracts;
using FrontEnd.Controller;

namespace FrontEnd.View.Controller
{
    public class ControlsAccess
    {
        private List<LabelController> Labels;
        private List<FormController> Forms;
        private List<RichTBController> RichTBs;
        private List<TextBoxController> TextBoxes;
        private List<NotifyController> IconNotifiers;
        private List<CalendarController> Calendars;
        private List<DatePickerController> DatePickers;
        private List<ListBoxController> ListBoxes;
        private List<EventDetailUserController> UserControllers;

        public ControlsAccess()
        {
            Setup();
        }

        private void Setup()
        {
            Labels = new List<LabelController>();
            Forms = new List<FormController>();
            RichTBs = new List<RichTBController>();
            IconNotifiers = new List<NotifyController>();
            Calendars = new List<CalendarController>();
            ListBoxes = new List<ListBoxController>();
            TextBoxes = new List<TextBoxController>();
            DatePickers = new List<DatePickerController>();
            UserControllers = new List<EventDetailUserController>();
        }

        public string Add(int type, object item)
        {
            switch(type)
            {
                case (int)ControlsType.Label:
                    Labels.Add(new LabelController((Label)item));
                    return Labels[Labels.Count - 1].Id;

                case (int)ControlsType.Forms:
                    Forms.Add(new FormController((Form)item));
                    return Forms[Forms.Count - 1].Id;

                case (int)ControlsType.RichTextArea:
                    RichTBs.Add(new RichTBController((RichTextBox)item));
                    return RichTBs[RichTBs.Count - 1].Id;

                case (int)ControlsType.TextArea:
                    TextBoxes.Add(new TextBoxController((TextBox)item));
                    return TextBoxes[TextBoxes.Count - 1].Id;

                case (int)ControlsType.IconNotifier:
                    IconNotifiers.Add(new NotifyController((NotifyIcon)item));
                    return IconNotifiers[IconNotifiers.Count - 1].Id;

                case (int)ControlsType.Calendar:
                    Calendars.Add(new CalendarController((MonthCalendar)item));
                    return Calendars[Calendars.Count - 1].Id;

                case (int)ControlsType.DatePicker:
                    DatePickers.Add(new DatePickerController((DateTimePicker)item));
                    return DatePickers[DatePickers.Count - 1].Id;

                case (int)ControlsType.ListBox:
                    ListBoxes.Add(new ListBoxController((ListBox)item));
                    return ListBoxes[ListBoxes.Count - 1].Id;

                case (int)ControlsType.UserForm:
                    UserControllers.Add(new EventDetailUserController((UserControl)item));
                    return UserControllers[UserControllers.Count - 1].Id;

                default: return "";
            }
        }

        public bool Remove(int type, string id)
        {
            switch (type)
            {
                case (int)ControlsType.Label:
                    return Labels.Remove(Labels.Single(item => string.Format("{0}", item.Control.Tag) == id));

                case (int)ControlsType.Forms:
                    return Forms.Remove(Forms.Single(item => string.Format("{0}", item.Control.Tag) == id));

                case (int)ControlsType.RichTextArea:
                    return RichTBs.Remove(RichTBs.Single(item => string.Format("{0}", item.Control.Tag) == id));

                case (int)ControlsType.TextArea:
                    return TextBoxes.Remove(TextBoxes.Single(item => string.Format("{0}", item.Control.Tag) == id));

                case (int)ControlsType.IconNotifier:
                    return IconNotifiers.Remove(IconNotifiers.Single(item => string.Format("{0}", item.Control.Tag) == id));

                case (int)ControlsType.Calendar:
                    return Calendars.Remove(Calendars.Single(item => string.Format("{0}", item.Control.Tag) == id));

                case (int)ControlsType.DatePicker:
                    return DatePickers.Remove(DatePickers.Single(item => string.Format("{0}", item.Control.Tag) == id));

                case (int)ControlsType.ListBox:
                    return ListBoxes.Remove(ListBoxes.Single(item => string.Format("{0}", item.Control.Tag) == id));

                default: return false;
            }
        }

        public object Get(int type, string id)
        {
            switch (type)
            {
                case (int)ControlsType.Label:
                    return Labels[Labels.IndexOf(Labels.Single(x => x.Id == id))];

                case (int)ControlsType.Forms:
                    return Forms[Forms.IndexOf(Forms.Single(x => x.Id == id))];

                case (int)ControlsType.RichTextArea:
                    return RichTBs[RichTBs.IndexOf(RichTBs.Single(x => x.Id == id))];

                case (int)ControlsType.TextArea:
                    return TextBoxes[TextBoxes.IndexOf(TextBoxes.Single(x => x.Id == id))];

                case (int)ControlsType.IconNotifier:
                    return IconNotifiers[IconNotifiers.IndexOf(IconNotifiers.Single(x => x.Id == id))];

                case (int)ControlsType.Calendar:
                    return Calendars[Calendars.IndexOf(Calendars.Single(x => x.Id == id))];

                case (int)ControlsType.DatePicker:
                    return DatePickers[DatePickers.IndexOf(DatePickers.Single(x => x.Id == id))];

                case (int)ControlsType.ListBox:
                    return ListBoxes[ListBoxes.IndexOf(ListBoxes.Single(x => x.Id == id))];

                default: return "";
            }
        }
    }

    public class FormController : ASetupController<Form>
    {
        public FormController(Form control) : base (control)
        {
            //Control is set in base class.

        }

        public void SetIcon(Icon icon)
        {
            Control.Icon = icon;
        }
    }

    public class NotifyController : ASetupController<NotifyIcon>
    {
        public NotifyController(NotifyIcon control) : base (control)
        {
            //Control is set in base class.
        }
    }

    public class LabelController : ASetupController<Label>
    {
        public LabelController(Label control) : base(control)
        {
            //Control is set in base class.
        }
    }

    public class CalendarController : ASetupController<MonthCalendar>
    {
        public CalendarController(MonthCalendar control) : base(control)
        {
            //Control is set in base class.
        }
    }


    public class DatePickerController : ASetupController<DateTimePicker>
    {
        public DatePickerController(DateTimePicker control) : base(control)
        {
            //Control is set in base class.
        }

        public string Date
        {
            get
            {
                return TimeAndDateUtility.ConvertDateTimeDate(Control.Value);
            }
        }

        public string Time
        {
            get
            {
                return TimeAndDateUtility.ConvertDateTimeTime(Control.Value);
            }
        }
    }

    public class EventDetailUserController : SetupCRUDControllerAbstract<UserControl>
    {
        public EventDetailUserController(UserControl control) : base(control)
        {
            //Control is set in base class.
        }
    }

    public class ListBoxController : ASetupController<ListBox>
    {

        public ListBoxController(ListBox control) : base(control)
        {
            //Control is set in base class.
        }

        public int Add(string title)
        {
            return Control.Items.Add(title);
        }

        public List<string> GetTitles()
        {
            return (List<string>) Control.Items.Cast<List<string>>();
        }
    }

    public class RichTBController : ASetupController<RichTextBox>
    {
        public RichTBController(RichTextBox control) : base(control)
        {
            //Control is set in base class.
        }

        public string Text
        {
            get { return Control.Text; }
        }
    }

    public class TextBoxController : ASetupController<TextBox>
    {
        public TextBoxController(TextBox control) : base(control)
        {
            //Control is set in base class.
        }

        public string Text
        {
            get { return Control.Text; }
        }
    }

    public class BookmarkViewController : SetupCRUDControllerAbstract<object>, IDisposable
    {
        private EventDetail _result;
        private BookmarkController _bookmarks;
        private GeneralForm _form;
        public ControlsAccess _controls;

        public BookmarkViewController (ControlsAccess controls, List<object> controllers) : base(controllers)
        {
            //Controls are set in base class
            _controls = controls;
            _bookmarks = new BookmarkController();
            _result = new EventDetail();
        }

        public void Add()
        {
            _form = new GeneralForm();
            _form.CreateView(CrudPurposes.Create, _controls);

            _form.ShowDialog();
            _result = _form.Results;

            if (_result != null)
            {
                _bookmarks.Add(_result);
            }
            _form.Close();
        }

        public void Update()
        {
            _form = new GeneralForm(_controls);
            _form.CreateView(CrudPurposes.Edit, _controls);

            _form.ShowDialog();
            _result = _form.Results;
            _form.Close();
        }

        public void Dispose()
        {
            _form.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
