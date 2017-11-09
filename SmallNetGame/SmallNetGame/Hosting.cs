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
    public partial class Hosting:Form {

        private Form1 mainForm;

        private UDPclient Broadcaster;

        public Hosting(Form1 form) {
            InitializeComponent();
            mainForm = form;
        }

        private void Hosting_Load(object sender, EventArgs e) {
            Broadcaster = new UDPclient();
            Broadcaster.Setup(mainForm.Data.Name);
        }

        private void SecondTick_Tick(object sender, EventArgs e) {
            if (Broadcaster != null) {
                Broadcaster.BroadCast(BroadCastingLabel);
            }
        }
    }
}
