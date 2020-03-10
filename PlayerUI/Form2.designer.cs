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
            this.button5 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_ContinueVideo = new System.Windows.Forms.Button();
            this.btn_pre15s = new System.Windows.Forms.Button();
            this.btn_Skip15s = new System.Windows.Forms.Button();
            this.btn_StopVideo = new System.Windows.Forms.Button();
            this.panel5.SuspendLayout();
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
            this.panel5.AutoScroll = true;
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.panel5.Controls.Add(this.btn_ContinueVideo);
            this.panel5.Controls.Add(this.btn_pre15s);
            this.panel5.Controls.Add(this.btn_Skip15s);
            this.panel5.Controls.Add(this.btn_StopVideo);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 385);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(782, 46);
            this.panel5.TabIndex = 8;
            // 
            // btn_ContinueVideo
            // 
            this.btn_ContinueVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_ContinueVideo.BackColor = System.Drawing.Color.Transparent;
            this.btn_ContinueVideo.FlatAppearance.BorderSize = 0;
            this.btn_ContinueVideo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_ContinueVideo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_ContinueVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ContinueVideo.ForeColor = System.Drawing.Color.White;
            this.btn_ContinueVideo.Image = global::PlayerUI.Properties.Resources._1_PAUSE1;
            this.btn_ContinueVideo.Location = new System.Drawing.Point(343, 8);
            this.btn_ContinueVideo.Name = "btn_ContinueVideo";
            this.btn_ContinueVideo.Size = new System.Drawing.Size(86, 34);
            this.btn_ContinueVideo.TabIndex = 1;
            this.btn_ContinueVideo.UseVisualStyleBackColor = false;
            this.btn_ContinueVideo.Click += new System.EventHandler(this.btn_ContinueVideo_Click);
            // 
            // btn_pre15s
            // 
            this.btn_pre15s.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_pre15s.BackColor = System.Drawing.Color.Transparent;
            this.btn_pre15s.FlatAppearance.BorderSize = 0;
            this.btn_pre15s.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_pre15s.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_pre15s.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pre15s.ForeColor = System.Drawing.Color.White;
            this.btn_pre15s.Image = global::PlayerUI.Properties.Resources._1_REWIND1;
            this.btn_pre15s.Location = new System.Drawing.Point(283, 8);
            this.btn_pre15s.Name = "btn_pre15s";
            this.btn_pre15s.Size = new System.Drawing.Size(86, 35);
            this.btn_pre15s.TabIndex = 0;
            this.btn_pre15s.UseVisualStyleBackColor = false;
            // 
            // btn_Skip15s
            // 
            this.btn_Skip15s.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Skip15s.BackColor = System.Drawing.Color.Transparent;
            this.btn_Skip15s.FlatAppearance.BorderSize = 0;
            this.btn_Skip15s.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Skip15s.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Skip15s.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Skip15s.ForeColor = System.Drawing.Color.White;
            this.btn_Skip15s.Image = global::PlayerUI.Properties.Resources._1_FORWARD1;
            this.btn_Skip15s.Location = new System.Drawing.Point(404, 8);
            this.btn_Skip15s.Name = "btn_Skip15s";
            this.btn_Skip15s.Size = new System.Drawing.Size(86, 35);
            this.btn_Skip15s.TabIndex = 3;
            this.btn_Skip15s.UseVisualStyleBackColor = false;
            // 
            // btn_StopVideo
            // 
            this.btn_StopVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_StopVideo.BackColor = System.Drawing.Color.Transparent;
            this.btn_StopVideo.FlatAppearance.BorderSize = 0;
            this.btn_StopVideo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_StopVideo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_StopVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_StopVideo.ForeColor = System.Drawing.Color.White;
            this.btn_StopVideo.Image = global::PlayerUI.Properties.Resources._1_PLAYBUTTON1;
            this.btn_StopVideo.Location = new System.Drawing.Point(343, 9);
            this.btn_StopVideo.Name = "btn_StopVideo";
            this.btn_StopVideo.Size = new System.Drawing.Size(86, 34);
            this.btn_StopVideo.TabIndex = 2;
            this.btn_StopVideo.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(782, 431);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.button5);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_ContinueVideo;
        private System.Windows.Forms.Button btn_pre15s;
        private System.Windows.Forms.Button btn_Skip15s;
        private System.Windows.Forms.Button btn_StopVideo;
    }
}