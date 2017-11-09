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

        public Form1() {
            InitializeComponent();
        }

        private void TheGame_Click(object sender, EventArgs e) {

        }

        private void TestServer_Click(object sender, EventArgs e) {

        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void GameLoop_Tick(object sender, EventArgs e) {
            if (selection != null) {
                if (IsAccessible) {
                    Hide();
                }
            } else {
                if (!IsAccessible) {
                    Show();
                }
            }
        }
    }
}
