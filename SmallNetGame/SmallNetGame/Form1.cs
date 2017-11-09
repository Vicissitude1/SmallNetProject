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
    public partial class Form1:Form {

        private Form selection = null;
        public SavedSessionData Data { get; private set; } = new SavedSessionData();


        public Form1() {
            InitializeComponent();
        }

        private void TheGame_Click(object sender, EventArgs e) {
            selection = new Login(this);
            selection.Show();
        }

        private void TestServer_Click(object sender, EventArgs e) {
            selection = new ServerTesting();
            selection.Show();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void GameLoop_Tick(object sender, EventArgs e) {
            if (selection != null) {
                if (selection.Visible) {
                    if (Visible) {
                        Hide();
                    }
                } else {
                    selection = null;
                }
            } else {
                if (!Visible) {
                    Show();
                }
            }
        }

        public void SetNewWindow(Form form) {
            if (selection != null) {
                selection.Dispose();
            }
            selection = form;
            form.Show();
        }






        public class SavedSessionData {

            public string Name { get; set; }

            public SavedSessionData() {
            }
        }
    }
}
