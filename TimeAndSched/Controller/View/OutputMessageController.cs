using Backend.Model;
using Shared.Utility;
using FrontEnd.App.Index.Views;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System;
using SharedItems.Abstracts;
using FrontEnd.Controller;
using Shared.Interface;

namespace FrontEnd.View.Controller
{
    public class ControlsAccess
    {
        /*Form ID => Control ID, Control*/
        private Dictionary<string, Dictionary<string, IControl>> Controls;

        public ControlsAccess()
        {
            Controls = new Dictionary<string, Dictionary<string, IControl>>();
        }

        public string AddForm(Form aForm)
        {
            var form = new FormController(aForm);
            Controls.Add(form.GetId(), new Dictionary<string, IControl>());

            return form.GetId();
        }

        public string Add(string formId, IControl aControl)
        {
            var form = Controls.Single(x => x.Key == formId).Value;
            form.Add(aControl.GetId(), aControl);

            return aControl.GetId();
        }

        public void Remove(string formId, string controlId)
        {
            var form = Controls.Single(x => x.Key == formId).Value;
            form.Remove(controlId);
        }

        public IControl Get(string formId, string controlId)
        {
            var form = Controls.Single(x => x.Key == formId).Value;
            form.TryGetValue(controlId, out IControl control);

            return control;
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
            GetControl().Icon = icon;
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
                return TimeAndDateUtility.ConvertDateTimeDateString(GetControl().Value);
            }
        }

        public string Time
        {
            get
            {
                return TimeAndDateUtility.ConvertDateTimeTimeString(GetControl().Value);
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
            return GetControl().Items.Add(title);
        }

        public List<string> GetTitles()
        {
            return GetControl().Items.Cast<List<string>>().FirstOrDefault();
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
            get { return GetControl().Text; }
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
            get { return GetControl().Text; }
        }
    }

    public class EventViewController : SetupCRUDControllerAbstract<List<IControl>>
    {
        private SavedEvent _result;
        private EventController _bookmarks;
        private GeneralForm _form;
        public ControlsAccess _controls;

        public EventViewController (ControlsAccess controls, List<IControl> controllers) : base(controllers)
        {
            //Controls are set in base class
            _controls = controls;
            _bookmarks = new EventController();
            _result = new SavedEvent();
        }

        public void Add()
        {
            _form = new GeneralForm(_controls);
            _form.CreateView(CrudPurposes.Create);

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
            _form.CreateView(CrudPurposes.Edit);

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
