using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmallNetGame {
    public partial class Login:Form {

        private Form1 mainForm;

        public Login(Form1 form) {
            InitializeComponent();
            mainForm = form;
        }

        private void Login_Load(object sender, EventArgs e) {

        }

        private void SetName_Click(object sender, EventArgs e) {
            string newString = string.Empty;
            Regex r = new Regex("[a-zA-Z0-9]");
            for (int i = 0; i < UsernameTextBox.Text.Length; i++) {
                if (r.IsMatch(UsernameTextBox.Text[i].ToString())) {
                    newString += UsernameTextBox.Text[i];
                }
            }
            mainForm.Data.Name = newString;
            mainForm.SetNewWindow(new Portal(mainForm));
        }
    }
}
