using System;
using System.Windows.Forms;
using Frontend.View.Controller;
using Backend.Model;
using Frontend.Controller.Parts;
using Frontend.Controller.Prompts;
using System.Drawing;
using Shared.Global;
using Frontend.App.Views;

namespace Frontend.App.Parts
{
    /// <summary>
    /// Partial class for Message Selection View
    /// </summary>
    public partial class MessagesView : UserControl
    {
        private const string DASH = "-";
        private const string NO_MESSAGE = "No message";
        private const string NO_AUTHORS = "No author(s)";
        private const string NO_SOURCES = "No source(s)";
        private const string SHOW = "Show";
        private const string HIDE = "Hide";
        private const string ENABLE = "Enabled";
        private const string DISABLE = "Disabled";

        private string _parentId;
        private MessageViewController _messages;
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
            _messages = controller;
            Setup();
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

        /// <summary>
        /// Updates the messages view
        /// </summary>
        public void UpdateMessagesView()
        {
            SearchTB.SetText(string.Empty);
            UpdateMessages();
            ToggleButtons(false, DASH);
        }

        /// <summary>
        /// Clears the message info view
        /// </summary>
        public void ClearMessageInfo()
        {
            ClearMessageDetails();
        }

        /// <summary>
        /// Sets the title of the Group Box
        /// </summary>
        /// <param name="title">The title to set</param>
        public void SetTitle(string title)
        {
            MessageInfoGB.Text = title;
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
            ToggleButtons(false, DASH);
            UpdateMessages();
        }

        private void MessageListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateMessageDetails();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (_messages.Add())
            {
                if (!_messages.SaveMessages())
                    MessageBox.Show("Unable to save some or all messages.", "Error Occurred.", MessageBoxButtons.OK, MessageBoxIcon.Error);

                ClearMessageDetails();
                ToggleButtons(false, DASH);
                SearchTB.SetText(string.Empty);
                UpdateMessages();
                ClearMessageDisplay();
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                string id = ((AppMessage)MessagesLB.SelectedIndex())?.Id;

                if (_messages.Update(id))
                {
                    if (!_messages.SaveMessages())
                        MessageBox.Show("Unable to save some or all messages.", "Error Occurred.", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    ClearMessageDetails();
                    ToggleButtons(false, DASH);
                    SearchTB.SetText(string.Empty);
                    UpdateMessages();
                    ClearMessageDisplay();
                }
            }
            catch (Exception)
            {
                // Something happened
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            try
            {
                string id = ((AppMessage)MessagesLB.SelectedIndex())?.Id;

                if (!string.IsNullOrEmpty(id) && _messages.Remove(id))
                {
                    if (!_messages.SaveMessages())
                        MessageBox.Show("Unable to save some or all messages.", "Error Occurred.", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    ClearMessageDetails();
                    ToggleButtons(false, DASH);
                    SearchTB.SetText(string.Empty);
                    UpdateMessages();
                    ClearMessageDisplay();
                }
            }
            catch(Exception)
            {
                //Something happened
            }
        }

        private void ToggleButton_Click(object sender, EventArgs e)
        {
            try
            {
                string id = ((AppMessage)MessagesLB.SelectedIndex())?.Id;

                if (!string.IsNullOrEmpty(id) && _messages.ToggleShow(id))
                {
                    if (!_messages.SaveMessages())
                        MessageBox.Show("Unable to save some or all messages.", "Error Occurred.", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    ClearMessageDetails();
                    ToggleButtons(false, DASH);
                    UpdateMessages();
                    ClearMessageDisplay();
                }
            }
            catch (Exception)
            {
                // Something happened
            }
        }

        private void Highlight_MouseLeave(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            label.BackColor = SystemColors.ControlLight;
            label.ForeColor = Color.Black;
        }

        private void Highlight_MouseHover(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            label.BackColor = SystemColors.ControlDark;
            label.ForeColor = Color.WhiteSmoke;
        }

        private void CopyMessage_Click(object sender, EventArgs e)
        {
            CopyMessage.Enabled = false;

            Clipboard.SetText(MessagePreviewTB.Text);
            PromptUser.Visible = true;
            PromptUser.Text = "Copied\r\n💾";

            Timer timer = new Timer
            {
                Interval = 1500
            };

            timer.Tick += (s, ee) =>
            {
                PromptUser.Visible = false;
                PromptUser.Text = string.Empty;
                timer.Stop();
                CopyMessage.Enabled = true;
            };

            timer.Start();
        }

        #region Helpers

        private void UpdateMessageDetails()
        {
            try
            {
                string id = ((AppMessage)MessagesLB.SelectedIndex())?.Id;
                if (!string.IsNullOrEmpty(id))
                {
                    AppMessage message = _messages.GetMessage(id);

                    if (message != null)
                    {
                        SetMessageDetails(message);
                        ToggleButtons(true, message.Show ? HIDE : SHOW);
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
            AuthorsTB.SetText(string.IsNullOrEmpty(message.Author) ? NO_AUTHORS : message.Author);
            SourcesTB.SetText(string.IsNullOrEmpty(message.Source) ? NO_SOURCES : message.Source);

            Date_Created.SetText(TimeAndDateUtility.ConvertDate_String(message.CreatedDate.Date, true));
            Time_Created.SetText(TimeAndDateUtility.ConvertTime_String(message.CreatedDate.Time));

            bool fullLastDisplayedDate = message.LastDisplayedDate == null || message.LastDisplayedDate.Date == null || message.LastDisplayedDate.Time == null;
            Last_Displayed_Date.SetText(fullLastDisplayedDate ?
                DASH : TimeAndDateUtility.ConvertDate_String(message.LastDisplayedDate.Date, true));

            Last_Displayed_Time.SetText(fullLastDisplayedDate ?
                DASH : TimeAndDateUtility.ConvertTime_String(message.LastDisplayedDate.Time));

            Status.SetText(message.Show ? ENABLE : DISABLE);
            Status.SetBackColor(message.Show ? Color.DarkGreen : Color.DarkRed);
            Status.SetForeColor(Color.WhiteSmoke);

            string preview = $"\"{MessageTB.Text}\"\r\n\r\n    - {AuthorsTB.Text}\r\n\r\nSources:\r\n    {SourcesTB.Text}";
            PreviewTB.SetText(preview);
        }

        private void UpdateMessages()
        {
            if (string.IsNullOrEmpty(SearchTB.Text))
            {
                object[] messages = _messages.GetAll();
                MessagesLB.Update(messages);
            }
            else
            {
                object[] messages = _messages.GetAll(SearchTB.Text);
                MessagesLB.Update(messages);
            }
        }

        private void ClearMessageDisplay()
        {
            MainApp form = (_controls.Get(_parentId, _parentId) as FormController).GetControl() as MainApp;
            form.TriggerDelayedRefresh();
        }

        private void ClearMessageDetails()
        {
            Title.SetText(DASH);
            Date_Created.SetText(DASH);
            Time_Created.SetText(DASH);
            Last_Displayed_Date.SetText(DASH);
            Last_Displayed_Time.SetText(DASH);
            Status.SetText(DASH);
            Status.SetBackColor(Color.DarkGray);
            Status.SetForeColor(Color.Black);

            MessageTB.SetText(NO_MESSAGE);
            PreviewTB.SetText(NO_MESSAGE);
            AuthorsTB.SetText(NO_AUTHORS);
            SourcesTB.SetText(NO_SOURCES);
        }

        private void ToggleButtons(bool enable, string toggleText)
        {
            EditButton.Enabled = enable;
            RemoveButton.Enabled = enable;
            ToggleButton.Enabled = enable;
            ToggleButton.Text = toggleText ?? ToggleButton.Text;
            CopyMessage.Enabled = enable;
            ExportAsImage.Enabled = enable;
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
