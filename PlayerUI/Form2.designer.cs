namespace PlayerUI
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.button5 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button18 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.LightGray;
            this.button5.Location = new System.Drawing.Point(0, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(25, 25);
            this.button5.TabIndex = 7;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.panel5.Controls.Add(this.button18);
            this.panel5.Controls.Add(this.button17);
            this.panel5.Controls.Add(this.button20);
            this.panel5.Controls.Add(this.button19);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 508);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(723, 48);
            this.panel5.TabIndex = 8;
            // 
            // button18
            // 
            this.button18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button18.BackColor = System.Drawing.Color.Transparent;
            this.button18.FlatAppearance.BorderSize = 0;
            this.button18.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button18.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.ForeColor = System.Drawing.Color.White;
            this.button18.Image = global::PlayerUI.Properties.Resources._1_PAUSE1;
            this.button18.Location = new System.Drawing.Point(320, 10);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(59, 35);
            this.button18.TabIndex = 1;
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button17
            // 
            this.button17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button17.BackColor = System.Drawing.Color.Transparent;
            this.button17.FlatAppearance.BorderSize = 0;
            this.button17.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button17.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.ForeColor = System.Drawing.Color.White;
            this.button17.Image = global::PlayerUI.Properties.Resources._1_REWIND1;
            this.button17.Location = new System.Drawing.Point(258, 10);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(59, 35);
            this.button17.TabIndex = 0;
            this.button17.UseVisualStyleBackColor = false;
            // 
            // button20
            // 
            this.button20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button20.BackColor = System.Drawing.Color.Transparent;
            this.button20.FlatAppearance.BorderSize = 0;
            this.button20.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button20.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button20.ForeColor = System.Drawing.Color.White;
            this.button20.Image = global::PlayerUI.Properties.Resources._1_FORWARD1;
            this.button20.Location = new System.Drawing.Point(385, 10);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(59, 35);
            this.button20.TabIndex = 3;
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button19
            // 
            this.button19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button19.BackColor = System.Drawing.Color.Transparent;
            this.button19.FlatAppearance.BorderSize = 0;
            this.button19.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button19.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.ForeColor = System.Drawing.Color.White;
            this.button19.Image = global::PlayerUI.Properties.Resources._1_PLAYBUTTON1;
            this.button19.Location = new System.Drawing.Point(306, 10);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(73, 35);
            this.button19.TabIndex = 2;
            this.button19.UseVisualStyleBackColor = false;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(723, 556);
            this.axWindowsMediaPlayer1.TabIndex = 9;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(723, 556);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button17;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}