using Backend.BusinessLogic.Model;
using Backend.OutputLogic.Utility;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TimeAndSched.App.Index.Implementations;
using TimeAndSched.App.Index.Views;
using TimeAndSched.FrontEnd.Globals;

namespace TimeAndSched.View.Controller
{
    public class ControlAccess
    {
        private List<LabelController> Labels;
        private List<FormController> Forms;
        private List<RichTBController> RichTBs;
        private List<TextBoxController> TextBoxes;
        private List<NotifyController> IconNotifiers;
        private List<CalendarController> Calendars;
        private List<DatePickerController> DatePickers;
        private List<ListBoxController> ListBoxes;

        public ControlAccess()
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
        }

        public string Add(ControlType type, object item)
        {
            switch(type)
            {
                case ControlType.Label:
                    Labels.Add(new LabelController((Label)item));
                    return Labels[Labels.Count - 1].Id;

                case ControlType.Forms:
                    Forms.Add(new FormController((Form)item));
                    return Forms[Forms.Count - 1].Id;

                case ControlType.RichTextArea:
                    RichTBs.Add(new RichTBController((RichTextBox)item));
                    return RichTBs[RichTBs.Count - 1].Id;

                case ControlType.TextArea:
                    TextBoxes.Add(new TextBoxController((TextBox)item));
                    return TextBoxes[TextBoxes.Count - 1].Id;

                case ControlType.IconNotifier:
                    IconNotifiers.Add(new NotifyController((NotifyIcon)item));
                    return IconNotifiers[IconNotifiers.Count - 1].Id;

                case ControlType.Calendar:
                    Calendars.Add(new CalendarController((MonthCalendar)item));
                    return Calendars[Calendars.Count - 1].Id;

                case ControlType.DatePicker:
                    DatePickers.Add(new DatePickerController((DateTimePicker)item));
                    return DatePickers[DatePickers.Count - 1].Id;

                case ControlType.ListBox:
                    ListBoxes.Add(new ListBoxController((ListBox)item));
                    return ListBoxes[ListBoxes.Count - 1].Id;

                default: return "";
            }
        }

        public bool Remove(ControlType type, string id)
        {
            switch (type)
            {
                case ControlType.Label:
                    return Labels.Remove(Labels.Single(item => string.Format("{0}", item.Control.Tag) == id));

                case ControlType.Forms:
                    return Forms.Remove(Forms.Single(item => string.Format("{0}", item.Control.Tag) == id));

                case ControlType.RichTextArea:
                    return RichTBs.Remove(RichTBs.Single(item => string.Format("{0}", item.Control.Tag) == id));

                case ControlType.TextArea:
                    return TextBoxes.Remove(TextBoxes.Single(item => string.Format("{0}", item.Control.Tag) == id));

                case ControlType.IconNotifier:
                    return IconNotifiers.Remove(IconNotifiers.Single(item => string.Format("{0}", item.Control.Tag) == id));

                case ControlType.Calendar:
                    return Calendars.Remove(Calendars.Single(item => string.Format("{0}", item.Control.Tag) == id));

                case ControlType.DatePicker:
                    return DatePickers.Remove(DatePickers.Single(item => string.Format("{0}", item.Control.Tag) == id));

                case ControlType.ListBox:
                    return ListBoxes.Remove(ListBoxes.Single(item => string.Format("{0}", item.Control.Tag) == id));

                default: return false;
            }
        }

        public object Get(ControlType type, string id)
        {
            switch (type)
            {
                case ControlType.Label:
                    return Labels[Labels.IndexOf(Labels.Single(x => x.Id == id))];

                case ControlType.Forms:
                    return Forms[Forms.IndexOf(Forms.Single(x => x.Id == id))];

                case ControlType.RichTextArea:
                    return RichTBs[RichTBs.IndexOf(RichTBs.Single(x => x.Id == id))];

                case ControlType.TextArea:
                    return TextBoxes[TextBoxes.IndexOf(TextBoxes.Single(x => x.Id == id))];

                case ControlType.IconNotifier:
                    return IconNotifiers[IconNotifiers.IndexOf(IconNotifiers.Single(x => x.Id == id))];

                case ControlType.Calendar:
                    return Calendars[Calendars.IndexOf(Calendars.Single(x => x.Id == id))];

                case ControlType.DatePicker:
                    return DatePickers[DatePickers.IndexOf(DatePickers.Single(x => x.Id == id))];

                case ControlType.ListBox:
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

    public class BookmarkViewController : ASetupCRUDController<object>
    {
        private EventDetail _result;
        private BookmarkController _bookmarks;
        private EventDetails _form;
        public ControlAccess _controls;

        public BookmarkViewController (ControlAccess controls, List<object> controllers) : base(controllers)
        {
            //Controls are set in base class
            _controls = controls;
            _bookmarks = new BookmarkController();
            _result = new EventDetail();
        }

        public void Add()
        {
            _form = new EventDetails(_controls);
            _form.SetPurpose(CrudPurpose.Create);

            _form.ShowDialog();
            _result = _form.Results;

            if (_result.Title != null)
            {
                _bookmarks.Add(_result);
            }
            
            _form.Close();
        }

        public void Update()
        {
            _form = new EventDetails(_controls);
            _form.SetPurpose(CrudPurpose.Edit);

            _form.ShowDialog();
            _result = _form.Results;
            _form.Close();
        }
    }
}
