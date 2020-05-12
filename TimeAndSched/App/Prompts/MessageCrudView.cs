﻿using Backend.Model;
using FrontEnd.Controller.Models;
using FrontEnd.View.Controller;
using Shared.Global;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEnd.App.Prompts
{
    /// <summary>
    /// Partial View Controller for Message CRUD
    /// </summary>
    public partial class MessageCrudView : Form
    {
        private readonly ControlsAccess _controls;
        private readonly string _id;

        public DialogResultData<AppMessage> Data { get; private set; }

        /// <summary>
        /// The constructor for Message CRUD
        /// </summary>
        /// <param name="controls">The library of existing controls</param>
        public MessageCrudView(ControlsAccess controls)
        {
            InitializeComponent();
            _controls = controls;

            Tag = _controls.AddForm(this);
            _id = Tag as string;
            Data = new DialogResultData<AppMessage>();
        }

        public void CreateView(CrudPurposes purpose, AppMessage message = null)
        {
            if (purpose == CrudPurposes.Error)
            {
                Error.Visible = true;
                MV.Visible = false;
            }
            else
            {
                Error.Visible = false;
                MV.Visible = true;
                MV.SetControls(_id, _controls);
                MV.SetPurpose(purpose);
            }

            if (purpose == CrudPurposes.Edit)
            {
                MV.SetValues(message);
            }
        }

        private void MessageCrudView_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResultData<AppMessage> data = MV.Data;
            AppMessage result = data.Results;
            DialogResult dialog = data.DialogResult;

            if (dialog == DialogResult.OK && result != null)
            {
                Data.Results = result;
                Data.DialogResult = dialog;
                MV.CleanUp();
            }
            else if (dialog == DialogResult.None)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
                Data.DialogResult = dialog;
                MV.CleanUp();
            }
        }
    }
}