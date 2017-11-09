namespace SmallNetGame {
    partial class Portal {
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
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.Host = new System.Windows.Forms.Button();
            this.Find = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(12, 9);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(55, 13);
            this.UsernameLabel.TabIndex = 0;
            this.UsernameLabel.Text = "Username";
            // 
            // Host
            // 
            this.Host.Location = new System.Drawing.Point(41, 106);
            this.Host.Name = "Host";
            this.Host.Size = new System.Drawing.Size(75, 23);
            this.Host.TabIndex = 1;
            this.Host.Text = "Host Game";
            this.Host.UseVisualStyleBackColor = true;
            this.Host.Click += new System.EventHandler(this.Host_Click);
            // 
            // Find
            // 
            this.Find.Location = new System.Drawing.Point(161, 106);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(75, 23);
            this.Find.TabIndex = 2;
            this.Find.Text = "Find Game";
            this.Find.UseVisualStyleBackColor = true;
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // Portal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Find);
            this.Controls.Add(this.Host);
            this.Controls.Add(this.UsernameLabel);
            this.Name = "Portal";
            this.Text = "Portal";
            this.Load += new System.EventHandler(this.Portal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Button Host;
        private System.Windows.Forms.Button Find;
    }
}