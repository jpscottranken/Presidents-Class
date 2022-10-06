namespace Presidents
{
    partial class frmHelp
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtInstructions = new System.Windows.Forms.TextBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblFollowUsOn = new System.Windows.Forms.Label();
            this.gbFollowUsOn = new System.Windows.Forms.GroupBox();
            this.cbTwitter = new System.Windows.Forms.CheckBox();
            this.cbInstagram = new System.Windows.Forms.CheckBox();
            this.cbFacebook = new System.Windows.Forms.CheckBox();
            this.gbFollowUsOn.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblTitle.Font = new System.Drawing.Font("Arial Narrow", 48F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(87, 35);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(904, 92);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Match The U.S. Presidents Game";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtInstructions
            // 
            this.txtInstructions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtInstructions.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold);
            this.txtInstructions.ForeColor = System.Drawing.Color.White;
            this.txtInstructions.Location = new System.Drawing.Point(100, 177);
            this.txtInstructions.Multiline = true;
            this.txtInstructions.Name = "txtInstructions";
            this.txtInstructions.ReadOnly = true;
            this.txtInstructions.Size = new System.Drawing.Size(891, 258);
            this.txtInstructions.TabIndex = 10;
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(100, 589);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(274, 73);
            this.btnHome.TabIndex = 11;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(717, 589);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(274, 73);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblFollowUsOn
            // 
            this.lblFollowUsOn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblFollowUsOn.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold);
            this.lblFollowUsOn.ForeColor = System.Drawing.Color.White;
            this.lblFollowUsOn.Location = new System.Drawing.Point(430, 448);
            this.lblFollowUsOn.Name = "lblFollowUsOn";
            this.lblFollowUsOn.Size = new System.Drawing.Size(196, 48);
            this.lblFollowUsOn.TabIndex = 13;
            this.lblFollowUsOn.Text = "Follow Us On:";
            this.lblFollowUsOn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbFollowUsOn
            // 
            this.gbFollowUsOn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gbFollowUsOn.Controls.Add(this.cbTwitter);
            this.gbFollowUsOn.Controls.Add(this.cbInstagram);
            this.gbFollowUsOn.Controls.Add(this.cbFacebook);
            this.gbFollowUsOn.ForeColor = System.Drawing.Color.White;
            this.gbFollowUsOn.Location = new System.Drawing.Point(430, 499);
            this.gbFollowUsOn.Name = "gbFollowUsOn";
            this.gbFollowUsOn.Size = new System.Drawing.Size(196, 163);
            this.gbFollowUsOn.TabIndex = 14;
            this.gbFollowUsOn.TabStop = false;
            // 
            // cbTwitter
            // 
            this.cbTwitter.AutoSize = true;
            this.cbTwitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cbTwitter.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTwitter.ForeColor = System.Drawing.Color.White;
            this.cbTwitter.Location = new System.Drawing.Point(35, 107);
            this.cbTwitter.Name = "cbTwitter";
            this.cbTwitter.Size = new System.Drawing.Size(97, 33);
            this.cbTwitter.TabIndex = 2;
            this.cbTwitter.Text = "Twitter";
            this.cbTwitter.UseVisualStyleBackColor = false;
            // 
            // cbInstagram
            // 
            this.cbInstagram.AutoSize = true;
            this.cbInstagram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cbInstagram.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbInstagram.ForeColor = System.Drawing.Color.White;
            this.cbInstagram.Location = new System.Drawing.Point(35, 64);
            this.cbInstagram.Name = "cbInstagram";
            this.cbInstagram.Size = new System.Drawing.Size(127, 33);
            this.cbInstagram.TabIndex = 1;
            this.cbInstagram.Text = "Instagram";
            this.cbInstagram.UseVisualStyleBackColor = false;
            // 
            // cbFacebook
            // 
            this.cbFacebook.AutoSize = true;
            this.cbFacebook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cbFacebook.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFacebook.ForeColor = System.Drawing.Color.White;
            this.cbFacebook.Location = new System.Drawing.Point(35, 19);
            this.cbFacebook.Name = "cbFacebook";
            this.cbFacebook.Size = new System.Drawing.Size(124, 33);
            this.cbFacebook.TabIndex = 0;
            this.cbFacebook.Text = "Facebook";
            this.cbFacebook.UseVisualStyleBackColor = false;
            // 
            // frmHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1086, 702);
            this.Controls.Add(this.gbFollowUsOn);
            this.Controls.Add(this.lblFollowUsOn);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.txtInstructions);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmHelp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Help Screen";
            this.Load += new System.EventHandler(this.frmHelp_Load);
            this.gbFollowUsOn.ResumeLayout(false);
            this.gbFollowUsOn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtInstructions;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblFollowUsOn;
        private System.Windows.Forms.GroupBox gbFollowUsOn;
        private System.Windows.Forms.CheckBox cbTwitter;
        private System.Windows.Forms.CheckBox cbInstagram;
        private System.Windows.Forms.CheckBox cbFacebook;
    }
}