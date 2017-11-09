namespace SmallNetGame {
    partial class Hosting {
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
            this.SecondTick = new System.Windows.Forms.Timer(this.components);
            this.BroadCastingLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SecondTick
            // 
            this.SecondTick.Enabled = true;
            this.SecondTick.Interval = 1000;
            this.SecondTick.Tick += new System.EventHandler(this.SecondTick_Tick);
            // 
            // BroadCastingLabel
            // 
            this.BroadCastingLabel.AutoSize = true;
            this.BroadCastingLabel.Location = new System.Drawing.Point(12, 19);
            this.BroadCastingLabel.Name = "BroadCastingLabel";
            this.BroadCastingLabel.Size = new System.Drawing.Size(96, 13);
            this.BroadCastingLabel.TabIndex = 0;
            this.BroadCastingLabel.Text = "BroadCastingLabel";
            // 
            // Hosting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.BroadCastingLabel);
            this.Name = "Hosting";
            this.Text = "Hosting";
            this.Load += new System.EventHandler(this.Hosting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer SecondTick;
        private System.Windows.Forms.Label BroadCastingLabel;
    }
}