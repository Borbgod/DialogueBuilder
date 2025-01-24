using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialogBuilder.MyTools.Forms
{
    public partial class DialogForm : Form
    {
        public DialogForm()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = this.btnOk.DialogResult;
            this.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.txtInput.Text = "";
            this.DialogResult = this.btnCancel.DialogResult;
            this.Visible = false;
        }
        public string GetString()
        {
            return this.txtInput.Text;
        }
        public void SetDefaultValues(string defaultValue, string prompt, string title)
        {
            this.txtInput.Text = defaultValue;
            this.lblPrompt.Text = prompt;
            this.Text = title;
        }
        public string GetString(string defaultValue, string prompt, string title)
        {
            this.txtInput.Text = defaultValue;
            this.lblPrompt.Text = prompt;
            this.Text = title;
            return this.txtInput.Text;
        }
    }
}
