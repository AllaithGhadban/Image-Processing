using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ImageProcessing
{
    public partial class frmVerification : Form
    {
        public frmVerification()
        {
            InitializeComponent();

        }
        //Declared as public in order to be accessed by the main form.
        public bool Certainty = false;
        public bool Cancel = true;
        private void btnAccept_Click(object sender, EventArgs e)
        {
            Certainty = true;
            Cancel = false;
            this.Hide();
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            Certainty = false;
            Cancel = false;
            this.Hide();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancel = true;
            Certainty = false;
            this.Hide();
        }
    }
}
