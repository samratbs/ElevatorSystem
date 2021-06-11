namespace ElevatorSystem
{
    partial class Elevator
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
            this.Logbtn = new System.Windows.Forms.Button();
            this.ControlGroupBox = new System.Windows.Forms.GroupBox();
            this.Upbtn = new System.Windows.Forms.PictureBox();
            this.Downbtn = new System.Windows.Forms.PictureBox();
            this.UpLeftDecor = new System.Windows.Forms.PictureBox();
            this.UpRightDecor = new System.Windows.Forms.PictureBox();
            this.DownRightDecor = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.DownRightLift = new System.Windows.Forms.PictureBox();
            this.UpLeftLift = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ControlDisplay = new System.Windows.Forms.PictureBox();
            this.FloorZerobtn = new System.Windows.Forms.Button();
            this.FloorOnebtn = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.DownLeftLift = new System.Windows.Forms.PictureBox();
            this.UpRightLift = new System.Windows.Forms.PictureBox();
            this.ControlPanel = new System.Windows.Forms.PictureBox();
            this.DownDisplay = new System.Windows.Forms.PictureBox();
            this.UpDisplay = new System.Windows.Forms.PictureBox();
            this.InsideLift = new System.Windows.Forms.PictureBox();
            this.DownLeftDecor = new System.Windows.Forms.PictureBox();
            this.MoveUpTimer = new System.Windows.Forms.Timer(this.components);
            this.MoveDownTimer = new System.Windows.Forms.Timer(this.components);
            this.DownCloseTimer = new System.Windows.Forms.Timer(this.components);
            this.UpCloseTimer = new System.Windows.Forms.Timer(this.components);
            this.UpOpenTimer = new System.Windows.Forms.Timer(this.components);
            this.DownOpenTimer = new System.Windows.Forms.Timer(this.components);
            this.LogBox = new System.Windows.Forms.ListBox();
            this.DateLabel = new System.Windows.Forms.Label();
            this.ActionLabel = new System.Windows.Forms.Label();
            this.AutoUpTimer = new System.Windows.Forms.Timer(this.components);
            this.AutoDownTimer = new System.Windows.Forms.Timer(this.components);
            this.Delay = new System.Windows.Forms.Timer(this.components);
            this.InsertLogbtn = new System.Windows.Forms.Button();
            this.DbBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.Upbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Downbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpLeftDecor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpRightDecor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownRightDecor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownRightLift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpLeftLift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ControlDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownLeftLift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpRightLift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ControlPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InsideLift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownLeftDecor)).BeginInit();
            this.SuspendLayout();
            // 
            // Logbtn
            // 
            this.Logbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Logbtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.Logbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Logbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Logbtn.Location = new System.Drawing.Point(1056, 678);
            this.Logbtn.Name = "Logbtn";
            this.Logbtn.Size = new System.Drawing.Size(120, 35);
            this.Logbtn.TabIndex = 18;
            this.Logbtn.Text = "Display Log";
            this.Logbtn.UseVisualStyleBackColor = false;
            this.Logbtn.Click += new System.EventHandler(this.Logbtn_Click);
            // 
            // ControlGroupBox
            // 
            this.ControlGroupBox.ForeColor = System.Drawing.Color.White;
            this.ControlGroupBox.Location = new System.Drawing.Point(426, 128);
            this.ControlGroupBox.Margin = new System.Windows.Forms.Padding(5);
            this.ControlGroupBox.Name = "ControlGroupBox";
            this.ControlGroupBox.Size = new System.Drawing.Size(181, 498);
            this.ControlGroupBox.TabIndex = 29;
            this.ControlGroupBox.TabStop = false;
            this.ControlGroupBox.Text = "Elevator Controls";
            // 
            // Upbtn
            // 
            this.Upbtn.Image = global::ElevatorSystem.Properties.Resources.UpBtn;
            this.Upbtn.Location = new System.Drawing.Point(306, 536);
            this.Upbtn.Name = "Upbtn";
            this.Upbtn.Size = new System.Drawing.Size(37, 41);
            this.Upbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Upbtn.TabIndex = 28;
            this.Upbtn.TabStop = false;
            this.Upbtn.Click += new System.EventHandler(this.Upbtn_Click);
            // 
            // Downbtn
            // 
            this.Downbtn.Image = global::ElevatorSystem.Properties.Resources.DownBtn;
            this.Downbtn.Location = new System.Drawing.Point(306, 128);
            this.Downbtn.Name = "Downbtn";
            this.Downbtn.Size = new System.Drawing.Size(37, 41);
            this.Downbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Downbtn.TabIndex = 27;
            this.Downbtn.TabStop = false;
            this.Downbtn.Click += new System.EventHandler(this.Downbtn_Click);
            // 
            // UpLeftDecor
            // 
            this.UpLeftDecor.Image = global::ElevatorSystem.Properties.Resources.Decoration;
            this.UpLeftDecor.Location = new System.Drawing.Point(1, 0);
            this.UpLeftDecor.Name = "UpLeftDecor";
            this.UpLeftDecor.Size = new System.Drawing.Size(103, 356);
            this.UpLeftDecor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UpLeftDecor.TabIndex = 6;
            this.UpLeftDecor.TabStop = false;
            // 
            // UpRightDecor
            // 
            this.UpRightDecor.Image = global::ElevatorSystem.Properties.Resources.Decoration;
            this.UpRightDecor.Location = new System.Drawing.Point(297, 0);
            this.UpRightDecor.Name = "UpRightDecor";
            this.UpRightDecor.Size = new System.Drawing.Size(103, 356);
            this.UpRightDecor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UpRightDecor.TabIndex = 5;
            this.UpRightDecor.TabStop = false;
            // 
            // DownRightDecor
            // 
            this.DownRightDecor.Image = global::ElevatorSystem.Properties.Resources.Decoration;
            this.DownRightDecor.Location = new System.Drawing.Point(1, 422);
            this.DownRightDecor.Name = "DownRightDecor";
            this.DownRightDecor.Size = new System.Drawing.Size(103, 365);
            this.DownRightDecor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DownRightDecor.TabIndex = 3;
            this.DownRightDecor.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::ElevatorSystem.Properties.Resources.FloorTile;
            this.pictureBox6.Location = new System.Drawing.Point(103, 747);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(197, 40);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 24;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::ElevatorSystem.Properties.Resources.FloorTile;
            this.pictureBox5.Location = new System.Drawing.Point(103, 316);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(197, 40);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 23;
            this.pictureBox5.TabStop = false;
            // 
            // DownRightLift
            // 
            this.DownRightLift.Image = global::ElevatorSystem.Properties.Resources.RightLift;
            this.DownRightLift.Location = new System.Drawing.Point(204, 460);
            this.DownRightLift.Name = "DownRightLift";
            this.DownRightLift.Size = new System.Drawing.Size(96, 289);
            this.DownRightLift.TabIndex = 22;
            this.DownRightLift.TabStop = false;
            // 
            // UpLeftLift
            // 
            this.UpLeftLift.Image = global::ElevatorSystem.Properties.Resources.LeftLift;
            this.UpLeftLift.Location = new System.Drawing.Point(103, 37);
            this.UpLeftLift.Name = "UpLeftLift";
            this.UpLeftLift.Size = new System.Drawing.Size(95, 280);
            this.UpLeftLift.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UpLeftLift.TabIndex = 21;
            this.UpLeftLift.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ElevatorSystem.Properties.Resources.Divider;
            this.pictureBox1.Location = new System.Drawing.Point(1, 390);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(399, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // ControlDisplay
            // 
            this.ControlDisplay.Image = global::ElevatorSystem.Properties.Resources.DisplayZero;
            this.ControlDisplay.Location = new System.Drawing.Point(479, 197);
            this.ControlDisplay.Name = "ControlDisplay";
            this.ControlDisplay.Size = new System.Drawing.Size(71, 94);
            this.ControlDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ControlDisplay.TabIndex = 17;
            this.ControlDisplay.TabStop = false;
            // 
            // FloorZerobtn
            // 
            this.FloorZerobtn.BackgroundImage = global::ElevatorSystem.Properties.Resources.GoZeroFloor;
            this.FloorZerobtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FloorZerobtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FloorZerobtn.Enabled = false;
            this.FloorZerobtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FloorZerobtn.Location = new System.Drawing.Point(468, 399);
            this.FloorZerobtn.Name = "FloorZerobtn";
            this.FloorZerobtn.Size = new System.Drawing.Size(95, 98);
            this.FloorZerobtn.TabIndex = 13;
            this.FloorZerobtn.UseVisualStyleBackColor = true;
            this.FloorZerobtn.Click += new System.EventHandler(this.FloorZerobtn_Click);
            // 
            // FloorOnebtn
            // 
            this.FloorOnebtn.BackgroundImage = global::ElevatorSystem.Properties.Resources.GoFirstFloor;
            this.FloorOnebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FloorOnebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FloorOnebtn.Enabled = false;
            this.FloorOnebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FloorOnebtn.Location = new System.Drawing.Point(468, 297);
            this.FloorOnebtn.Name = "FloorOnebtn";
            this.FloorOnebtn.Size = new System.Drawing.Size(95, 96);
            this.FloorOnebtn.TabIndex = 12;
            this.FloorOnebtn.UseVisualStyleBackColor = true;
            this.FloorOnebtn.Click += new System.EventHandler(this.FloorOnebtn_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ElevatorSystem.Properties.Resources.Divider;
            this.pictureBox3.Location = new System.Drawing.Point(1, 356);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(399, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // DownLeftLift
            // 
            this.DownLeftLift.Image = global::ElevatorSystem.Properties.Resources.LeftLift;
            this.DownLeftLift.Location = new System.Drawing.Point(103, 460);
            this.DownLeftLift.Name = "DownLeftLift";
            this.DownLeftLift.Size = new System.Drawing.Size(95, 290);
            this.DownLeftLift.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DownLeftLift.TabIndex = 1;
            this.DownLeftLift.TabStop = false;
            // 
            // UpRightLift
            // 
            this.UpRightLift.Image = global::ElevatorSystem.Properties.Resources.RightLift;
            this.UpRightLift.Location = new System.Drawing.Point(204, 37);
            this.UpRightLift.Name = "UpRightLift";
            this.UpRightLift.Size = new System.Drawing.Size(96, 280);
            this.UpRightLift.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UpRightLift.TabIndex = 0;
            this.UpRightLift.TabStop = false;
            // 
            // ControlPanel
            // 
            this.ControlPanel.Image = global::ElevatorSystem.Properties.Resources.Panel;
            this.ControlPanel.Location = new System.Drawing.Point(434, 149);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(164, 471);
            this.ControlPanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ControlPanel.TabIndex = 26;
            this.ControlPanel.TabStop = false;
            // 
            // DownDisplay
            // 
            this.DownDisplay.Image = global::ElevatorSystem.Properties.Resources.DisplayZero;
            this.DownDisplay.Location = new System.Drawing.Point(184, 422);
            this.DownDisplay.Name = "DownDisplay";
            this.DownDisplay.Size = new System.Drawing.Size(33, 41);
            this.DownDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DownDisplay.TabIndex = 16;
            this.DownDisplay.TabStop = false;
            // 
            // UpDisplay
            // 
            this.UpDisplay.Image = global::ElevatorSystem.Properties.Resources.DisplayZero;
            this.UpDisplay.Location = new System.Drawing.Point(184, 0);
            this.UpDisplay.Name = "UpDisplay";
            this.UpDisplay.Size = new System.Drawing.Size(33, 39);
            this.UpDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UpDisplay.TabIndex = 11;
            this.UpDisplay.TabStop = false;
            // 
            // InsideLift
            // 
            this.InsideLift.Image = global::ElevatorSystem.Properties.Resources.OpenLift;
            this.InsideLift.Location = new System.Drawing.Point(103, 469);
            this.InsideLift.Name = "InsideLift";
            this.InsideLift.Size = new System.Drawing.Size(197, 284);
            this.InsideLift.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.InsideLift.TabIndex = 25;
            this.InsideLift.TabStop = false;
            // 
            // DownLeftDecor
            // 
            this.DownLeftDecor.Image = global::ElevatorSystem.Properties.Resources.Decoration;
            this.DownLeftDecor.Location = new System.Drawing.Point(297, 422);
            this.DownLeftDecor.Name = "DownLeftDecor";
            this.DownLeftDecor.Size = new System.Drawing.Size(103, 365);
            this.DownLeftDecor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DownLeftDecor.TabIndex = 4;
            this.DownLeftDecor.TabStop = false;
            // 
            // MoveUpTimer
            // 
            this.MoveUpTimer.Interval = 10;
            this.MoveUpTimer.Tick += new System.EventHandler(this.MoveUpTimer_Tick);
            // 
            // MoveDownTimer
            // 
            this.MoveDownTimer.Interval = 10;
            this.MoveDownTimer.Tick += new System.EventHandler(this.MoveDownTimer_Tick);
            // 
            // DownCloseTimer
            // 
            this.DownCloseTimer.Interval = 10;
            this.DownCloseTimer.Tick += new System.EventHandler(this.DownCloseTimer_Tick);
            // 
            // UpCloseTimer
            // 
            this.UpCloseTimer.Interval = 10;
            this.UpCloseTimer.Tick += new System.EventHandler(this.UpCloseTimer_Tick);
            // 
            // UpOpenTimer
            // 
            this.UpOpenTimer.Interval = 10;
            this.UpOpenTimer.Tick += new System.EventHandler(this.UpOpenTimer_Tick);
            // 
            // DownOpenTimer
            // 
            this.DownOpenTimer.Interval = 10;
            this.DownOpenTimer.Tick += new System.EventHandler(this.DownOpenTimer_Tick);
            // 
            // LogBox
            // 
            this.LogBox.FormattingEnabled = true;
            this.LogBox.ItemHeight = 16;
            this.LogBox.Location = new System.Drawing.Point(689, 60);
            this.LogBox.Name = "LogBox";
            this.LogBox.Size = new System.Drawing.Size(516, 612);
            this.LogBox.TabIndex = 30;
            this.LogBox.SelectedIndexChanged += new System.EventHandler(this.Logbtn_Click);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.ForeColor = System.Drawing.Color.Black;
            this.DateLabel.Location = new System.Drawing.Point(689, 21);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(153, 25);
            this.DateLabel.TabIndex = 31;
            this.DateLabel.Text = "Date and Time";
            // 
            // ActionLabel
            // 
            this.ActionLabel.AutoSize = true;
            this.ActionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActionLabel.ForeColor = System.Drawing.Color.Black;
            this.ActionLabel.Location = new System.Drawing.Point(959, 21);
            this.ActionLabel.Name = "ActionLabel";
            this.ActionLabel.Size = new System.Drawing.Size(73, 25);
            this.ActionLabel.TabIndex = 32;
            this.ActionLabel.Text = "Action";
            // 
            // AutoUpTimer
            // 
            this.AutoUpTimer.Interval = 10;
            this.AutoUpTimer.Tick += new System.EventHandler(this.AutoUpTimer_Tick);
            // 
            // AutoDownTimer
            // 
            this.AutoDownTimer.Interval = 10;
            this.AutoDownTimer.Tick += new System.EventHandler(this.AutoDownTimer_Tick);
            // 
            // Delay
            // 
            this.Delay.Interval = 5000;
            this.Delay.Tick += new System.EventHandler(this.Delay_Tick);
            // 
            // InsertLogbtn
            // 
            this.InsertLogbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.InsertLogbtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.InsertLogbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InsertLogbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.InsertLogbtn.Location = new System.Drawing.Point(722, 678);
            this.InsertLogbtn.Name = "InsertLogbtn";
            this.InsertLogbtn.Size = new System.Drawing.Size(120, 35);
            this.InsertLogbtn.TabIndex = 33;
            this.InsertLogbtn.Text = "Insert Log";
            this.InsertLogbtn.UseVisualStyleBackColor = false;
            this.InsertLogbtn.Click += new System.EventHandler(this.InsertLogbtn_Click);
            // 
            // DbBackgroundWorker
            // 
            this.DbBackgroundWorker.WorkerReportsProgress = true;
            this.DbBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.DbBackgroundWorker_DoWork);
            // 
            // Elevator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1217, 786);
            this.Controls.Add(this.InsertLogbtn);
            this.Controls.Add(this.ActionLabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.LogBox);
            this.Controls.Add(this.Upbtn);
            this.Controls.Add(this.DownLeftDecor);
            this.Controls.Add(this.Downbtn);
            this.Controls.Add(this.UpLeftDecor);
            this.Controls.Add(this.UpRightDecor);
            this.Controls.Add(this.DownRightDecor);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.DownRightLift);
            this.Controls.Add(this.UpLeftLift);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Logbtn);
            this.Controls.Add(this.ControlDisplay);
            this.Controls.Add(this.FloorZerobtn);
            this.Controls.Add(this.FloorOnebtn);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.DownLeftLift);
            this.Controls.Add(this.UpRightLift);
            this.Controls.Add(this.ControlPanel);
            this.Controls.Add(this.DownDisplay);
            this.Controls.Add(this.UpDisplay);
            this.Controls.Add(this.InsideLift);
            this.Controls.Add(this.ControlGroupBox);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "Elevator";
            this.Text = "Elevator";
            ((System.ComponentModel.ISupportInitialize)(this.Upbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Downbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpLeftDecor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpRightDecor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownRightDecor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownRightLift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpLeftLift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ControlDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownLeftLift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpRightLift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ControlPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InsideLift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownLeftDecor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox UpRightLift;
        private System.Windows.Forms.PictureBox DownLeftLift;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox DownRightDecor;
        private System.Windows.Forms.PictureBox DownLeftDecor;
        private System.Windows.Forms.PictureBox UpRightDecor;
        private System.Windows.Forms.PictureBox UpLeftDecor;
        private System.Windows.Forms.PictureBox UpDisplay;
        private System.Windows.Forms.Button FloorOnebtn;
        private System.Windows.Forms.Button FloorZerobtn;
        private System.Windows.Forms.PictureBox DownDisplay;
        private System.Windows.Forms.PictureBox ControlDisplay;
        private System.Windows.Forms.Button Logbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox UpLeftLift;
        private System.Windows.Forms.PictureBox DownRightLift;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox InsideLift;
        private System.Windows.Forms.PictureBox ControlPanel;
        private System.Windows.Forms.PictureBox Downbtn;
        private System.Windows.Forms.PictureBox Upbtn;
        private System.Windows.Forms.GroupBox ControlGroupBox;
        private System.Windows.Forms.Timer MoveUpTimer;
        private System.Windows.Forms.Timer MoveDownTimer;
        private System.Windows.Forms.Timer DownCloseTimer;
        private System.Windows.Forms.Timer UpCloseTimer;
        private System.Windows.Forms.Timer UpOpenTimer;
        private System.Windows.Forms.Timer DownOpenTimer;
        private System.Windows.Forms.ListBox LogBox;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label ActionLabel;
        private System.Windows.Forms.Timer AutoUpTimer;
        private System.Windows.Forms.Timer AutoDownTimer;
        private System.Windows.Forms.Timer Delay;
        private System.Windows.Forms.Button InsertLogbtn;
        private System.ComponentModel.BackgroundWorker DbBackgroundWorker;
    }
}

