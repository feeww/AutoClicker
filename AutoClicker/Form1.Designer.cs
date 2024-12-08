namespace AutoClicker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            cbTopMost = new CheckBox();
            rbLeftClick = new RadioButton();
            rbRightClick = new RadioButton();
            numInterval = new NumericUpDown();
            lblInterval = new Label();
            btnStart = new Button();
            btnStop = new Button();
            btnBindHotkey = new Button();
            lblHotkey = new Label();
            ((System.ComponentModel.ISupportInitialize)numInterval).BeginInit();
            SuspendLayout();
            // 
            // cbTopMost
            // 
            cbTopMost.AutoSize = true;
            cbTopMost.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbTopMost.ForeColor = SystemColors.ButtonHighlight;
            cbTopMost.Location = new Point(158, 19);
            cbTopMost.Name = "cbTopMost";
            cbTopMost.Size = new Size(100, 23);
            cbTopMost.TabIndex = 0;
            cbTopMost.Text = "Top Most";
            cbTopMost.UseVisualStyleBackColor = true;
            cbTopMost.CheckedChanged += cbTopMost_CheckedChanged;
            // 
            // rbLeftClick
            // 
            rbLeftClick.AutoSize = true;
            rbLeftClick.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbLeftClick.ForeColor = SystemColors.ButtonHighlight;
            rbLeftClick.Location = new Point(264, 19);
            rbLeftClick.Name = "rbLeftClick";
            rbLeftClick.Size = new Size(117, 23);
            rbLeftClick.TabIndex = 1;
            rbLeftClick.TabStop = true;
            rbLeftClick.Text = "Left Click";
            rbLeftClick.UseVisualStyleBackColor = true;
            // 
            // rbRightClick
            // 
            rbRightClick.AutoSize = true;
            rbRightClick.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbRightClick.ForeColor = SystemColors.ButtonHighlight;
            rbRightClick.Location = new Point(264, 48);
            rbRightClick.Name = "rbRightClick";
            rbRightClick.Size = new Size(126, 23);
            rbRightClick.TabIndex = 2;
            rbRightClick.TabStop = true;
            rbRightClick.Text = "Right Click";
            rbRightClick.UseVisualStyleBackColor = true;
            // 
            // numInterval
            // 
            numInterval.Location = new Point(12, 41);
            numInterval.Name = "numInterval";
            numInterval.Size = new Size(120, 23);
            numInterval.TabIndex = 3;
            numInterval.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblInterval
            // 
            lblInterval.AutoSize = true;
            lblInterval.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInterval.ForeColor = SystemColors.ButtonHighlight;
            lblInterval.Location = new Point(12, 19);
            lblInterval.Name = "lblInterval";
            lblInterval.Size = new Size(117, 19);
            lblInterval.TabIndex = 4;
            lblInterval.Text = "Interval(ms)";
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStart.Location = new Point(12, 81);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(132, 38);
            btnStart.TabIndex = 5;
            btnStart.Text = "Start(F6)";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStop.Location = new Point(12, 135);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(132, 38);
            btnStop.TabIndex = 6;
            btnStop.Text = "Stop(F6)";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // btnBindHotkey
            // 
            btnBindHotkey.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBindHotkey.Location = new Point(251, 135);
            btnBindHotkey.Name = "btnBindHotkey";
            btnBindHotkey.Size = new Size(160, 38);
            btnBindHotkey.TabIndex = 7;
            btnBindHotkey.Text = "Change Hotkey";
            btnBindHotkey.UseVisualStyleBackColor = true;
            btnBindHotkey.Click += btnBindHotkey_Click;
            // 
            // lblHotkey
            // 
            lblHotkey.AutoSize = true;
            lblHotkey.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHotkey.ForeColor = SystemColors.ButtonHighlight;
            lblHotkey.Location = new Point(251, 113);
            lblHotkey.Name = "lblHotkey";
            lblHotkey.Size = new Size(108, 19);
            lblHotkey.TabIndex = 8;
            lblHotkey.Text = "Hotkey : F6";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(423, 198);
            Controls.Add(lblHotkey);
            Controls.Add(btnBindHotkey);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Controls.Add(lblInterval);
            Controls.Add(numInterval);
            Controls.Add(rbRightClick);
            Controls.Add(rbLeftClick);
            Controls.Add(cbTopMost);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "AutoClicker";
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)numInterval).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox cbTopMost;
        private RadioButton rbLeftClick;
        private RadioButton rbRightClick;
        private NumericUpDown numInterval;
        private Label lblInterval;
        private Button btnStart;
        private Button btnStop;
        private Button btnBindHotkey;
        private Label lblHotkey;
    }
}
