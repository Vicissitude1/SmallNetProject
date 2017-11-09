using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmallNetGame {
    public partial class Portal:Form {

        private Form1 mainForm;

        public Portal(Form1 form) {
            InitializeComponent();
            mainForm = form;
        }

        private void Portal_Load(object sender, EventArgs e) {
            UsernameLabel.Text = "Name: " + mainForm.Data.Name;
        }

        private void Host_Click(object sender, EventArgs e) {

        }

        private void Find_Click(object sender, EventArgs e) {

        }
    }
}
