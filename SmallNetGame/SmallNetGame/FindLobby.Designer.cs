namespace SmallNetGame {
    partial class FindLobby {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.Lobbies = new System.Windows.Forms.TextBox();
            this.Refresh = new System.Windows.Forms.Button();
            this.Ticker = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Lobbies
            // 
            this.Lobbies.Location = new System.Drawing.Point(12, 12);
            this.Lobbies.Multiline = true;
            this.Lobbies.Name = "Lobbies";
            this.Lobbies.Size = new System.Drawing.Size(260, 184);
            this.Lobbies.TabIndex = 0;
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(96, 217);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(75, 23);
            this.Refresh.TabIndex = 1;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // Ticker
            // 
            this.Ticker.Enabled = true;
            this.Ticker.Tick += new System.EventHandler(this.Ticker_Tick);
            // 
            // FindLobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.Lobbies);
            this.Name = "FindLobby";
            this.Text = "FindLobby";
            this.Load += new System.EventHandler(this.FindLobby_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Lobbies;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Timer Ticker;
    }
}