using System;
using System.Windows.Forms;
using FrontEnd.View.Controller;
using Backend.Model;
using FrontEnd.Controller.Parts;
using FrontEnd.Controller.Prompts;
using System.Drawing;
using Shared.Model;
using Shared.Global;

namespace FrontEnd.App.Parts
{
    /// <summary>
    /// Partial class for Message Selection View
    /// </summary>
    public partial class MessagesView : UserControl
    {
        private string _parentId;
        private MessageViewController _controller;
        private ControlsAccess _controls;

        /// <summary>
        /// Constructor for the Partial View Controllers
        /// </summary>
        public MessagesView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sets up the controls access for Message Select View
        /// </summary>
        /// <param name="parentId">The id of the parent</param>
        /// <param name="controls">The controls</param>
        /// <param name="controller">The controller to use</param>
        public void SetControls(string parentId, ControlsAccess controls, MessageViewController controller)
        {
            _controls = controls;
            _parentId = parentId;
            _controller = controller;
            Setup();
        }

        /// <summary>
        /// Updates the messages view
        /// </summary>
        public void UpdateMessagesView()
        {
            SearchTB.SetText(string.Empty);
            UpdateMessages();
            ToggleButtons(false, "-");
        }

        /// <summary>
        /// Sets the title of the Group Box
        /// </summary>
        /// <param name="title">The title to set</param>
        public void SetTitle(string title)
        {
            MessageInfoGB.Text = title;
        }

        private void Setup()
        {
            MessageSearchBox.Tag = _controls.Add(_parentId, new TextBoxController(MessageSearchBox));
            MessageInfoTB.Tag = _controls.Add(_parentId, new TextBoxController(MessageInfoTB));
            MessagePreviewTB.Tag = _controls.Add(_parentId, new TextBoxController(MessagePreviewTB));
            MessageAuthorsTB.Tag = _controls.Add(_parentId, new TextBoxController(MessageAuthorsTB));
            MessageSourcesTB.Tag = _controls.Add(_parentId, new TextBoxController(MessageSourcesTB));

            MessageTitleLB.Tag = _controls.Add(_parentId, new LabelController(MessageTitleLB));
            MessageStatusLB.Tag = _controls.Add(_parentId, new LabelController(MessageStatusLB));
            MessageDateCreatedLB.Tag = _controls.Add(_parentId, new LabelController(MessageDateCreatedLB));
            MessageTimeCreatedLB.Tag = _controls.Add(_parentId, new LabelController(MessageTimeCreatedLB));
            MessageLastDateDisplayedLB.Tag = _controls.Add(_parentId, new LabelController(MessageLastDateDisplayedLB));
            MessageLastTimeDisplayedLB.Tag = _controls.Add(_parentId, new LabelController(MessageLastTimeDisplayedLB));

            MessageListBox.Tag = _controls.Add(_parentId, new ListBoxController(MessageListBox));

            MessagesLB.SetMembers("Title", "Id");
        }

        private void SearchBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchButton.PerformClick();
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            ClearMessageDetails();
            ToggleButtons(false, "-");
            UpdateMessages();
        }

        private void MessageListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateMessageDetails();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (_controller.Add())
            {
                ClearMessageDetails();
                ToggleButtons(false, "-");
                UpdateMessages();
                SearchTB.SetText(string.Empty);
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                string id = ((AppMessage)MessagesLB.SelectedIndex())?.Id;

                if (_controller.Update(null))
                {
                    ClearMessageDetails();
                    ToggleButtons(false, "-");
                    UpdateMessages();
                    SearchTB.SetText(string.Empty);
                }
            }
            catch (Exception)
            {
                //Something happened
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            try
            {
                string id = ((AppMessage)MessagesLB.SelectedIndex())?.Id;

                if (!string.IsNullOrEmpty(id) && _controller.Remove(id))
                {
                    ClearMessageDetails();
                    ToggleButtons(false, "-");
                    UpdateMessages();
                    SearchTB.SetText(string.Empty);
                }
            }
            catch(Exception)
            {
                //Something happened
            }
        }

        private void ToggleButton_Click(object sender, EventArgs e)
        {
            string id = ((AppMessage)MessagesLB.SelectedIndex())?.Id;

            if (!string.IsNullOrEmpty(id) && _controller.ToggleShow(id))
            {
                ClearMessageDetails();
                ToggleButtons(false, "-");
                UpdateMessages();
            }
        }

        #region Helpers

        private void UpdateMessageDetails()
        {
            try
            {
                string id = ((AppMessage)MessagesLB.SelectedIndex())?.Id;
                if (!string.IsNullOrEmpty(id))
                {
                    AppMessage message = _controller.GetMessage(id);

                    if (message != null)
                    {
                        SetMessageDetails(message);
                        ToggleButtons(true, message.Show ? "Hide" : "Show");
                    }
                }
            }
            catch (Exception)
            {
                // Something happened
            }
        }

        private void SetMessageDetails(AppMessage message)
        {
            Title.SetText(message.Title);
            MessageTB.SetText(message.Quote);
            AuthorsTB.SetText(string.IsNullOrEmpty(message.Author) ? "No Author(s)" : message.Author);
            SourcesTB.SetText(string.IsNullOrEmpty(message.Source) ? "No Source(s)" : message.Source);

            Date_Created.SetText(TimeAndDateUtility.ConvertDate_String(message.DateCreated, true));
            Time_Created.SetText(TimeAndDateUtility.ConvertTime_String(message.TimeCreated));

            bool fullLastDisplayedDate = message.LastDateDisplayed == null || message.LastTimeDisplayed == null;
            Last_Displayed_Date.SetText(fullLastDisplayedDate ?
                "-" : TimeAndDateUtility.ConvertDate_String(message.LastDateDisplayed, true));

            Last_Displayed_Time.SetText(fullLastDisplayedDate ?
                "-" : TimeAndDateUtility.ConvertTime_String(message.LastTimeDisplayed));

            Status.SetText(message.Show ? "Enabled" :"Disabled");
            Status.SetBackColor(message.Show ? Color.DarkGreen : Color.DarkRed);
            Status.SetForeColor(Color.WhiteSmoke);

            string preview = $"\"{MessageTB.Text}\"\r\n\r\n    -{AuthorsTB.Text}\r\n\r\nSources:\r\n    {SourcesTB.Text}";
            PreviewTB.SetText(preview);
        }

        private void UpdateMessages()
        {
            if (string.IsNullOrEmpty(SearchTB.Text))
            {
                object[] messages = _controller.GetAll();
                MessagesLB.Update(messages);
            }
            else
            {
                object[] messages = _controller.GetAll(SearchTB.Text);
                MessagesLB.Update(messages);
            }
        }

        private void ToggleButtons(bool enable, string toggleText)
        {
            EditButton.Enabled = enable;
            RemoveButton.Enabled = enable;
            ToggleButton.Enabled = enable;
            ToggleButton.Text = toggleText ?? ToggleButton.Text;
        }

        private void ClearMessageDetails()
        {
            const string dash = "-";
            const string no_message = "No message";
            const string no_authors = "No author(s)";
            const string no_sources = "No source(s)";

            Title.SetText(dash);
            Date_Created.SetText(dash);
            Time_Created.SetText(dash);
            Last_Displayed_Date.SetText(dash);
            Last_Displayed_Time.SetText(dash);
            Status.SetText(dash);
            Status.SetBackColor(Color.DarkGray);
            Status.SetForeColor(Color.Black);

            MessageTB.SetText(no_message);
            PreviewTB.SetText(no_message);
            AuthorsTB.SetText(no_authors);
            SourcesTB.SetText(no_sources);
        }

        #endregion Helpers

        #region Cleanup

        public void Cleanup()
        {
            _controls.Remove(_parentId, SearchTB.GetId());
            _controls.Remove(_parentId, MessageTB.GetId());
            _controls.Remove(_parentId, PreviewTB.GetId());
            _controls.Remove(_parentId, AuthorsTB.GetId());
            _controls.Remove(_parentId, SourcesTB.GetId());
            _controls.Remove(_parentId, MessagesLB.GetId());
            _controls.Remove(_parentId, Title.GetId());
            _controls.Remove(_parentId, Status.GetId());
            _controls.Remove(_parentId, Date_Created.GetId());
            _controls.Remove(_parentId, Time_Created.GetId());
            _controls.Remove(_parentId, Last_Displayed_Date.GetId());
            _controls.Remove(_parentId, Last_Displayed_Time.GetId());
        }

        #endregion Cleanup

        #region Controllers [Only use once view is initialized]

        #region [ TextBoxes ]

        private TextBoxController SearchTB => (TextBoxController)_controls.Get(_parentId, MessageSearchBox.Tag as string);

        private TextBoxController MessageTB => (TextBoxController)_controls.Get(_parentId, MessageInfoTB.Tag as string);

        private TextBoxController PreviewTB => (TextBoxController)_controls.Get(_parentId, MessagePreviewTB.Tag as string);

        private TextBoxController AuthorsTB => (TextBoxController)_controls.Get(_parentId, MessageAuthorsTB.Tag as string);

        private TextBoxController SourcesTB => (TextBoxController)_controls.Get(_parentId, MessageSourcesTB.Tag as string);

        #endregion

        #region [ Label ]

        private LabelController Title => (LabelController)_controls.Get(_parentId, MessageTitleLB.Tag as string);

        private LabelController Status => (LabelController)_controls.Get(_parentId, MessageStatusLB.Tag as string);

        private LabelController Date_Created => (LabelController)_controls.Get(_parentId, MessageDateCreatedLB.Tag as string);

        private LabelController Time_Created => (LabelController)_controls.Get(_parentId, MessageTimeCreatedLB.Tag as string);

        private LabelController Last_Displayed_Date => (LabelController)_controls.Get(_parentId, MessageLastDateDisplayedLB.Tag as string);

        private LabelController Last_Displayed_Time => (LabelController)_controls.Get(_parentId, MessageLastTimeDisplayedLB.Tag as string);

        #endregion

        #region [ ListBoxes ]

        private ListBoxController MessagesLB => (ListBoxController)_controls.Get(_parentId, MessageListBox.Tag as string);

        #endregion

        #endregion
    }
}
