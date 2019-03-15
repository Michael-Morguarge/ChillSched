using Backend.BusinessLogic.Repository;
using FrontEnd.View.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrontEnd.Globals;
using Backend.BusinessLogic.Model;

namespace FrontEnd.App.Index.Views
{
    public partial class GeneralForm : Form
    {
        private ControlAccess _controls;
        private EventDetailRepository _repo;

        public EventDetail Results { get; private set; }

        public GeneralForm()
        {
            InitializeComponent();
        }

        public GeneralForm(ControlAccess controls)
        {
            _controls = controls;
        }

        public void CreateView(CrudPurpose purpose, ControlAccess controls)
        {
            if (purpose == CrudPurpose.Error)
            {
                Error.Visible = true;
                //eventInfoView.Visible = false;
                return;
            }
            else
            {
                Error.Visible = false;
                //eventInfoView.Visible = true;
                _repo = new EventDetailRepository();
                //eventInfoView.SetControls(controls);
                //eventInfoView.SetPurpose(purpose);
            }
        }
    }
}
