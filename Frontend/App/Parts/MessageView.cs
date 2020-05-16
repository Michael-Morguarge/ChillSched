using System.Windows.Forms;
using Backend.Model;
using Frontend.Controller.Models;
using Frontend.Controller.Parts;
using Frontend.View.Controller;
using Shared.Global;

namespace Frontend.App.Parts
{
    /// <summary>
    /// Partial View Controller
    /// </summary>
    public partial class MessageView : UserControl
    {
        private CrudPurposes _purpose;
        private string _parentId;
        private ControlsAccess _controls;

        /// <summary>
        /// the data of the prompt
        /// </summary>
        public DialogResultData<AppMessage> Data { get; private set; }

        /// <summary>
        /// Constructor for the Partial View Controllers
        /// </summary>
        public MessageView()
        {
            InitializeComponent();
        }

        public void SetControls(string parentId, ControlsAccess controls)
        {
            _controls = controls;
            _parentId = parentId;
            Data = new DialogResultData<AppMessage>();
            Setup();
        }

        private void Setup()
        {
            AuthorLB.Tag = _controls.Add(_parentId, new LabelController(AuthorLB));
            QuoteLB.Tag = _controls.Add(_parentId, new LabelController(QuoteLB));
            SourceLB.Tag = _controls.Add(_parentId, new LabelController(SourceLB));
            TitleLB.Tag = _controls.Add(_parentId, new LabelController(TitleLB));

            MessageAuthorTB.Tag = _controls.Add(_parentId, new TextBoxController(MessageAuthorTB));
            MessageQuoteTB.Tag = _controls.Add(_parentId, new TextBoxController(MessageQuoteTB));
            MessageSourceTB.Tag = _controls.Add(_parentId, new TextBoxController(MessageSourceTB));
            MessageTitleTB.Tag = _controls.Add(_parentId, new TextBoxController(MessageTitleTB));

            MessageHideRB.Checked = true;
        }

        public void SetPurpose(CrudPurposes purpose)
        {
            Data.Results = new AppMessage();
            Data.Error = false;
            _purpose = purpose;
            SetTitle();
        }

        private void SetTitle()
        {
            switch(_purpose)
            {
                case CrudPurposes.None:
                    {
                        Data.Error = false;
                        MessageModal.Enabled = true;
                        Confirm.Enabled = false;
                        Confirm.Visible = false;
                        MessageModal.Text = "View Message";
                        Confirm.Text = "...";
                        Cancel.Text = "Ok";
                        break;
                    }

                case CrudPurposes.Create:
                    {
                        Data.Error = false;
                        MessageModal.Enabled = true;
                        Confirm.Enabled = true;
                        Confirm.Visible = true;
                        MessageModal.Text = "Create Message";
                        Confirm.Text = "Create";
                        Cancel.Text = "Cancel";
                        break;
                    }

                case CrudPurposes.Edit:
                    {
                        Data.Error = false;
                        MessageModal.Enabled = true;
                        Confirm.Enabled = true;
                        Confirm.Visible = true;
                        MessageModal.Text = "View Message";
                        Confirm.Text = "Update";
                        Cancel.Text = "Cancel";
                        break;
                    }

                case CrudPurposes.Error:
                    {
                        Data.Error = true;
                        MessageModal.Enabled = false;
                        Confirm.Enabled = false;
                        Confirm.Visible = false;
                        MessageModal.Text = "Error";
                        Confirm.Text = "...";
                        Cancel.Text = "Ok";
                        break;
                    }

                default:
                    {
                        Data.Error = true;
                        MessageModal.Enabled = false;
                        Confirm.Enabled = false;
                        Confirm.Visible = false;
                        MessageModal.Text = "...";
                        Confirm.Text = "...";
                        Cancel.Text = "Ok";
                        break;
                    }
            }
        }

        public void SetValues(AppMessage message)
        {
            TitleTB.SetText(message.Title);
            QuoteTB.SetText(message.Quote);
            AuthorTB.SetText(message.Author);
            SourceTB.SetText(message.Source);

            if (message.Show)
                MessageShowRB.Checked = true;
            else
                MessageHideRB.Checked = true;
        }

        private void Confirm_Click(object sender, System.EventArgs e)
        {
            bool error = false;
            Label title = Title.GetControl();
            Label quote = Quote.GetControl();

            if (TitleTB.Text == string.Empty)
            {
                Title.SetText(title.Text.Contains("*") ? title.Text : string.Format("{0}*", title.Text));
                error = true;
            }
            else
            {
                Title.SetText(title.Text.Contains("*") ? title.Text.Remove(title.Text.Length - 1) : title.Text);
            }

            if (string.IsNullOrEmpty(QuoteTB.Text) || QuoteTB.Text.Length > 32766)
            {
                Quote.SetText(quote.Text.Contains("*") ? quote.Text : string.Format("{0}*", quote.Text));
                error = true;
            }
            else
            {
                Quote.SetText(quote.Text.Contains("*") ? quote.Text.Remove(quote.Text.Length - 1) : quote.Text);
            }

            if (error)
            {
                Data.DialogResult = DialogResult.None;
                Data.Error = true;
            }
            else
            {
                Data.DialogResult = DialogResult.OK;
                Data.Results = new AppMessage
                {
                    Title = TitleTB.Text,
                    Quote = QuoteTB.Text,
                    Author = AuthorTB.Text,
                    Source = SourceTB.Text,
                    Show = MessageShowRB.Checked
                };

                Data.Error = false;

                ((Form)TopLevelControl).Close();
            }
        }

        private void Cancel_Click(object sender, System.EventArgs e)
        {
            if (Cancel.Text == "Ok")
            {
                Data.DialogResult = DialogResult.Cancel;
            }
            else
            {
                DialogResult result = MessageBox.Show("Do you want to discard the changes to the message?", "All progress lost of not submitted", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Data.DialogResult = DialogResult.Cancel;
                }
                else if (result == DialogResult.No || result == DialogResult.None)
                {
                    Data.DialogResult = DialogResult.None;
                }
            }
        }

        #region Cleanup

        public void CleanUp()
        {
            _controls.Remove(_parentId, TitleTB.GetId());
            _controls.Remove(_parentId, QuoteTB.GetId());
            _controls.Remove(_parentId, AuthorTB.GetId());
            _controls.Remove(_parentId, SourceTB.GetId());
        }

        #endregion

        #region Controllers [Only use once view is initialized]

        #region [ TextBoxes ]

        private TextBoxController TitleTB => (TextBoxController)_controls.Get(_parentId, MessageTitleTB.Tag as string);

        private TextBoxController QuoteTB => (TextBoxController)_controls.Get(_parentId, MessageQuoteTB.Tag as string);

        private TextBoxController SourceTB => (TextBoxController)_controls.Get(_parentId, MessageSourceTB.Tag as string);

        private TextBoxController AuthorTB => (TextBoxController)_controls.Get(_parentId, MessageAuthorTB.Tag as string);

        #endregion

        #region [ Labels ]

        private LabelController Title => (LabelController)_controls.Get(_parentId, TitleLB.Tag as string);

        private LabelController Author => (LabelController)_controls.Get(_parentId, AuthorLB.Tag as string);

        private LabelController Quote => (LabelController)_controls.Get(_parentId, QuoteLB.Tag as string);

        private LabelController Source => (LabelController)_controls.Get(_parentId, SourceLB.Tag as string);

        #endregion

        #endregion
    }
}
