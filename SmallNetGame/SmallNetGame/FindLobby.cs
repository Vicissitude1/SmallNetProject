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
    public partial class FindLobby:Form {

        private Form1 mainForm;
        private UDPserver reciever;

        public FindLobby(Form1 form) {
            InitializeComponent();
            mainForm = form;
        }

        private void Refresh_Click(object sender, EventArgs e) {

        }

        private void FindLobby_Load(object sender, EventArgs e) {
            reciever = new UDPserver();
            reciever.StartListener(Lobbies);
        }

        private void Ticker_Tick(object sender, EventArgs e) {
            if (reciever != null) {
                reciever.UpdateTextBox();
            }
        }
    }
}
