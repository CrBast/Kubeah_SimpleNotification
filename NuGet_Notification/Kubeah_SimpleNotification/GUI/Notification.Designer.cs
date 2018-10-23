namespace Kubeah_SimpleNotification.GUI
{
    partial class Notification
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notification));
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.tbxContent = new System.Windows.Forms.TextBox();
            this.pbxArrow = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.topMost = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArrow)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxLogo
            // 
            this.pbxLogo.Location = new System.Drawing.Point(10, 9);
            this.pbxLogo.Margin = new System.Windows.Forms.Padding(0);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(32, 32);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 6;
            this.pbxLogo.TabStop = false;
            // 
            // tbxContent
            // 
            this.tbxContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxContent.Enabled = false;
            this.tbxContent.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxContent.ForeColor = System.Drawing.Color.White;
            this.tbxContent.Location = new System.Drawing.Point(16, 27);
            this.tbxContent.Multiline = true;
            this.tbxContent.Name = "tbxContent";
            this.tbxContent.ReadOnly = true;
            this.tbxContent.Size = new System.Drawing.Size(301, 52);
            this.tbxContent.TabIndex = 7;
            // 
            // pbxArrow
            // 
            this.pbxArrow.Image = ((System.Drawing.Image)(resources.GetObject("pbxArrow.Image")));
            this.pbxArrow.Location = new System.Drawing.Point(329, 8);
            this.pbxArrow.Name = "pbxArrow";
            this.pbxArrow.Size = new System.Drawing.Size(16, 16);
            this.pbxArrow.TabIndex = 8;
            this.pbxArrow.TabStop = false;
            this.pbxArrow.Click += new System.EventHandler(this.pbxArrow_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(13, 7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(51, 16);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "lblTitle";
            // 
            // timer
            // 
            this.timer.Interval = 5000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // topMost
            // 
            this.topMost.Enabled = true;
            this.topMost.Tick += new System.EventHandler(this.topMost_Tick);
            // 
            // Notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(353, 97);
            this.Controls.Add(this.pbxLogo);
            this.Controls.Add(this.pbxArrow);
            this.Controls.Add(this.tbxContent);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Notification";
            this.Text = "Notification";
            this.Load += new System.EventHandler(this.Notification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArrow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.TextBox tbxContent;
        private System.Windows.Forms.PictureBox pbxArrow;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer topMost;
    }
}