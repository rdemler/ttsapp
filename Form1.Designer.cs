namespace ttsapp
{
    partial class Form1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.QR_ThankYou_Button = new System.Windows.Forms.Button();
            this.QR_Look_Button = new System.Windows.Forms.Button();
            this.QR_ExplainVoice_Button = new System.Windows.Forms.Button();
            this.QR_Dunno_Button = new System.Windows.Forms.Button();
            this.QR_No_button = new System.Windows.Forms.Button();
            this.QR_Yes_Button = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Rate_Label = new System.Windows.Forms.Label();
            this.Rate_TrackBar = new System.Windows.Forms.TrackBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Voice_ComboBox = new System.Windows.Forms.ComboBox();
            this.Voice_Label = new System.Windows.Forms.Label();
            this.Text_TextBox = new System.Windows.Forms.TextBox();
            this.TextToSpeak_Label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Clear_Button = new System.Windows.Forms.Button();
            this.Speak_Button = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Volume_Label = new System.Windows.Forms.Label();
            this.Volume_TrackBar = new System.Windows.Forms.TrackBar();
            this.Quit_Button = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Rate_TrackBar)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Volume_TrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.panel5, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Text_TextBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TextToSpeak_Label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.Quit_Button, 2, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(526, 417);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel5, 2);
            this.panel5.Controls.Add(this.QR_ThankYou_Button);
            this.panel5.Controls.Add(this.QR_Look_Button);
            this.panel5.Controls.Add(this.QR_ExplainVoice_Button);
            this.panel5.Controls.Add(this.QR_Dunno_Button);
            this.panel5.Controls.Add(this.QR_No_button);
            this.panel5.Controls.Add(this.QR_Yes_Button);
            this.panel5.Location = new System.Drawing.Point(175, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(351, 26);
            this.panel5.TabIndex = 4;
            // 
            // QR_ThankYou_Button
            // 
            this.QR_ThankYou_Button.Location = new System.Drawing.Point(190, 3);
            this.QR_ThankYou_Button.Name = "QR_ThankYou_Button";
            this.QR_ThankYou_Button.Size = new System.Drawing.Size(68, 23);
            this.QR_ThankYou_Button.TabIndex = 5;
            this.QR_ThankYou_Button.Text = "Thank You";
            this.QR_ThankYou_Button.UseVisualStyleBackColor = true;
            this.QR_ThankYou_Button.Click += new System.EventHandler(this.QR_Yes_Button_Click);
            // 
            // QR_Look_Button
            // 
            this.QR_Look_Button.Location = new System.Drawing.Point(138, 3);
            this.QR_Look_Button.Name = "QR_Look_Button";
            this.QR_Look_Button.Size = new System.Drawing.Size(46, 23);
            this.QR_Look_Button.TabIndex = 4;
            this.QR_Look_Button.Text = "Look";
            this.QR_Look_Button.UseVisualStyleBackColor = true;
            this.QR_Look_Button.Click += new System.EventHandler(this.QR_Yes_Button_Click);
            // 
            // QR_ExplainVoice_Button
            // 
            this.QR_ExplainVoice_Button.Location = new System.Drawing.Point(264, 3);
            this.QR_ExplainVoice_Button.Name = "QR_ExplainVoice_Button";
            this.QR_ExplainVoice_Button.Size = new System.Drawing.Size(84, 23);
            this.QR_ExplainVoice_Button.TabIndex = 3;
            this.QR_ExplainVoice_Button.Text = "Explain Voice";
            this.QR_ExplainVoice_Button.UseVisualStyleBackColor = true;
            this.QR_ExplainVoice_Button.Click += new System.EventHandler(this.QR_Yes_Button_Click);
            // 
            // QR_Dunno_Button
            // 
            this.QR_Dunno_Button.Location = new System.Drawing.Point(84, 3);
            this.QR_Dunno_Button.Name = "QR_Dunno_Button";
            this.QR_Dunno_Button.Size = new System.Drawing.Size(48, 23);
            this.QR_Dunno_Button.TabIndex = 2;
            this.QR_Dunno_Button.Text = "Dunno";
            this.QR_Dunno_Button.UseVisualStyleBackColor = true;
            this.QR_Dunno_Button.Click += new System.EventHandler(this.QR_Yes_Button_Click);
            // 
            // QR_No_button
            // 
            this.QR_No_button.Location = new System.Drawing.Point(43, 3);
            this.QR_No_button.Name = "QR_No_button";
            this.QR_No_button.Size = new System.Drawing.Size(35, 23);
            this.QR_No_button.TabIndex = 1;
            this.QR_No_button.Text = "No";
            this.QR_No_button.UseVisualStyleBackColor = true;
            this.QR_No_button.Click += new System.EventHandler(this.QR_Yes_Button_Click);
            // 
            // QR_Yes_Button
            // 
            this.QR_Yes_Button.Location = new System.Drawing.Point(2, 3);
            this.QR_Yes_Button.Name = "QR_Yes_Button";
            this.QR_Yes_Button.Size = new System.Drawing.Size(35, 23);
            this.QR_Yes_Button.TabIndex = 0;
            this.QR_Yes_Button.Text = "Yes";
            this.QR_Yes_Button.UseVisualStyleBackColor = true;
            this.QR_Yes_Button.Click += new System.EventHandler(this.QR_Yes_Button_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Rate_Label);
            this.panel3.Controls.Add(this.Rate_TrackBar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(175, 339);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(175, 26);
            this.panel3.TabIndex = 3;
            // 
            // Rate_Label
            // 
            this.Rate_Label.AutoSize = true;
            this.Rate_Label.Location = new System.Drawing.Point(5, 7);
            this.Rate_Label.Name = "Rate_Label";
            this.Rate_Label.Size = new System.Drawing.Size(30, 13);
            this.Rate_Label.TabIndex = 2;
            this.Rate_Label.Text = "Rate";
            // 
            // Rate_TrackBar
            // 
            this.Rate_TrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Rate_TrackBar.Location = new System.Drawing.Point(53, 2);
            this.Rate_TrackBar.Minimum = -10;
            this.Rate_TrackBar.Name = "Rate_TrackBar";
            this.Rate_TrackBar.Size = new System.Drawing.Size(119, 45);
            this.Rate_TrackBar.TabIndex = 1;
            this.Rate_TrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.Rate_TrackBar.Value = 2;
            this.Rate_TrackBar.Scroll += new System.EventHandler(this.Rate_TrackBar_Scroll);
            // 
            // panel2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel2, 3);
            this.panel2.Controls.Add(this.Voice_ComboBox);
            this.panel2.Controls.Add(this.Voice_Label);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 365);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(526, 26);
            this.panel2.TabIndex = 3;
            // 
            // Voice_ComboBox
            // 
            this.Voice_ComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Voice_ComboBox.FormattingEnabled = true;
            this.Voice_ComboBox.Location = new System.Drawing.Point(44, 3);
            this.Voice_ComboBox.Name = "Voice_ComboBox";
            this.Voice_ComboBox.Size = new System.Drawing.Size(479, 21);
            this.Voice_ComboBox.TabIndex = 4;
            this.Voice_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Voice_ComboBox_SelectedIndexChanged);
            // 
            // Voice_Label
            // 
            this.Voice_Label.AutoSize = true;
            this.Voice_Label.Location = new System.Drawing.Point(3, 7);
            this.Voice_Label.Name = "Voice_Label";
            this.Voice_Label.Size = new System.Drawing.Size(34, 13);
            this.Voice_Label.TabIndex = 3;
            this.Voice_Label.Text = "Voice";
            // 
            // Text_TextBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.Text_TextBox, 3);
            this.Text_TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Text_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_TextBox.Location = new System.Drawing.Point(3, 29);
            this.Text_TextBox.Multiline = true;
            this.Text_TextBox.Name = "Text_TextBox";
            this.Text_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Text_TextBox.Size = new System.Drawing.Size(520, 307);
            this.Text_TextBox.TabIndex = 3;
            this.Text_TextBox.TextChanged += new System.EventHandler(this.Text_TextBox_TextChanged);
            // 
            // TextToSpeak_Label
            // 
            this.TextToSpeak_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TextToSpeak_Label.AutoSize = true;
            this.TextToSpeak_Label.Location = new System.Drawing.Point(3, 13);
            this.TextToSpeak_Label.Name = "TextToSpeak_Label";
            this.TextToSpeak_Label.Size = new System.Drawing.Size(74, 13);
            this.TextToSpeak_Label.TabIndex = 0;
            this.TextToSpeak_Label.Text = "Text to Speak";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Clear_Button);
            this.panel1.Controls.Add(this.Speak_Button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 339);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 26);
            this.panel1.TabIndex = 2;
            // 
            // Clear_Button
            // 
            this.Clear_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Clear_Button.Location = new System.Drawing.Point(84, 2);
            this.Clear_Button.Name = "Clear_Button";
            this.Clear_Button.Size = new System.Drawing.Size(75, 23);
            this.Clear_Button.TabIndex = 0;
            this.Clear_Button.Text = "Clear";
            this.Clear_Button.UseVisualStyleBackColor = true;
            this.Clear_Button.Click += new System.EventHandler(this.Clear_Button_Click);
            // 
            // Speak_Button
            // 
            this.Speak_Button.Location = new System.Drawing.Point(3, 2);
            this.Speak_Button.Name = "Speak_Button";
            this.Speak_Button.Size = new System.Drawing.Size(75, 23);
            this.Speak_Button.TabIndex = 0;
            this.Speak_Button.Text = "Speak";
            this.Speak_Button.UseVisualStyleBackColor = true;
            this.Speak_Button.Click += new System.EventHandler(this.Speak_Button_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.Volume_Label);
            this.panel4.Controls.Add(this.Volume_TrackBar);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(350, 339);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(176, 26);
            this.panel4.TabIndex = 4;
            // 
            // Volume_Label
            // 
            this.Volume_Label.AutoSize = true;
            this.Volume_Label.Location = new System.Drawing.Point(5, 7);
            this.Volume_Label.Name = "Volume_Label";
            this.Volume_Label.Size = new System.Drawing.Size(42, 13);
            this.Volume_Label.TabIndex = 2;
            this.Volume_Label.Text = "Volume";
            // 
            // Volume_TrackBar
            // 
            this.Volume_TrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Volume_TrackBar.Location = new System.Drawing.Point(53, 2);
            this.Volume_TrackBar.Maximum = 100;
            this.Volume_TrackBar.Name = "Volume_TrackBar";
            this.Volume_TrackBar.Size = new System.Drawing.Size(120, 45);
            this.Volume_TrackBar.TabIndex = 1;
            this.Volume_TrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.Volume_TrackBar.Value = 100;
            this.Volume_TrackBar.Scroll += new System.EventHandler(this.Volume_TrackBar_Scroll);
            // 
            // Quit_Button
            // 
            this.Quit_Button.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Quit_Button.Location = new System.Drawing.Point(448, 394);
            this.Quit_Button.Name = "Quit_Button";
            this.Quit_Button.Size = new System.Drawing.Size(75, 20);
            this.Quit_Button.TabIndex = 0;
            this.Quit_Button.Text = "Quit";
            this.Quit_Button.UseVisualStyleBackColor = true;
            this.Quit_Button.Click += new System.EventHandler(this.Quit_Button_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.Speak_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Clear_Button;
            this.ClientSize = new System.Drawing.Size(526, 417);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Speak";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Rate_TrackBar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Volume_TrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox Text_TextBox;
        private System.Windows.Forms.Button Quit_Button;
        private System.Windows.Forms.Label TextToSpeak_Label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Clear_Button;
        private System.Windows.Forms.Button Speak_Button;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Voice_Label;
        private System.Windows.Forms.ComboBox Voice_ComboBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Rate_Label;
        private System.Windows.Forms.TrackBar Rate_TrackBar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label Volume_Label;
        private System.Windows.Forms.TrackBar Volume_TrackBar;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button QR_ThankYou_Button;
        private System.Windows.Forms.Button QR_Look_Button;
        private System.Windows.Forms.Button QR_ExplainVoice_Button;
        private System.Windows.Forms.Button QR_Dunno_Button;
        private System.Windows.Forms.Button QR_No_button;
        private System.Windows.Forms.Button QR_Yes_Button;
    }
}

