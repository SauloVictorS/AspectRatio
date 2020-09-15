namespace Resize_and_Aspect_Ratio
{
    partial class Resize
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ProportionalPanel = new System.Windows.Forms.Panel();
            this.AnchorPanel = new System.Windows.Forms.Panel();
            this.AnchorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProportionalPanel
            // 
            this.ProportionalPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ProportionalPanel.Location = new System.Drawing.Point(12, 12);
            this.ProportionalPanel.Name = "ProportionalPanel";
            this.ProportionalPanel.Size = new System.Drawing.Size(476, 328);
            this.ProportionalPanel.TabIndex = 0;
            // 
            // AnchorPanel
            // 
            this.AnchorPanel.BackColor = System.Drawing.Color.LightBlue;
            this.AnchorPanel.Controls.Add(this.ProportionalPanel);
            this.AnchorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AnchorPanel.Location = new System.Drawing.Point(0, 0);
            this.AnchorPanel.Name = "AnchorPanel";
            this.AnchorPanel.Size = new System.Drawing.Size(500, 350);
            this.AnchorPanel.TabIndex = 1;
            this.AnchorPanel.SizeChanged += new System.EventHandler(this.AnchorPanel_SizeChanged);
            // 
            // Resize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 350);
            this.Controls.Add(this.AnchorPanel);
            this.Name = "Resize";
            this.Text = "Aspect Ratio";
            this.AnchorPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ProportionalPanel;
        private System.Windows.Forms.Panel AnchorPanel;
    }
}