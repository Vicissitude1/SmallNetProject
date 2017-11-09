namespace SmallNetGame {
    partial class Form1 {
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
            this.TheGame = new System.Windows.Forms.Button();
            this.TestServer = new System.Windows.Forms.Button();
            this.GameLoop = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // TheGame
            // 
            this.TheGame.Location = new System.Drawing.Point(50, 108);
            this.TheGame.Name = "TheGame";
            this.TheGame.Size = new System.Drawing.Size(75, 23);
            this.TheGame.TabIndex = 0;
            this.TheGame.Text = "TheGame";
            this.TheGame.UseVisualStyleBackColor = true;
            this.TheGame.Click += new System.EventHandler(this.TheGame_Click);
            // 
            // TestServer
            // 
            this.TestServer.Location = new System.Drawing.Point(155, 108);
            this.TestServer.Name = "TestServer";
            this.TestServer.Size = new System.Drawing.Size(75, 23);
            this.TestServer.TabIndex = 1;
            this.TestServer.Text = "TestServer";
            this.TestServer.UseVisualStyleBackColor = true;
            this.TestServer.Click += new System.EventHandler(this.TestServer_Click);
            // 
            // GameLoop
            // 
            this.GameLoop.Enabled = true;
            this.GameLoop.Interval = 30;
            this.GameLoop.Tick += new System.EventHandler(this.GameLoop_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.TestServer);
            this.Controls.Add(this.TheGame);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TheGame;
        private System.Windows.Forms.Button TestServer;
        private System.Windows.Forms.Timer GameLoop;
    }
}

