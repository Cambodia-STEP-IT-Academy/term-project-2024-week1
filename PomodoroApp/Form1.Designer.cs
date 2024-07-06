namespace PomodoroApp
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
            textBox1 = new TextBox();
            label1 = new Label();
            WorkDuration = new NumericUpDown();
            label2 = new Label();
            WaitingTime = new Label();
            ButtonStart = new Button();
            ButtonStop = new Button();
            label4 = new Label();
            label5 = new Label();
            ShortBreak = new NumericUpDown();
            LongBreak = new NumericUpDown();
            Lapses = new Label();
            BreakDuration = new Label();
            ((System.ComponentModel.ISupportInitialize)WorkDuration).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ShortBreak).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LongBreak).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(12, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(586, 33);
            textBox1.TabIndex = 0;
            textBox1.Text = "Baking a Cake";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 58);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 1;
            label1.Text = "Time:";
            // 
            // WorkDuration
            // 
            WorkDuration.Location = new Point(54, 56);
            WorkDuration.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            WorkDuration.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            WorkDuration.Name = "WorkDuration";
            WorkDuration.Size = new Size(42, 23);
            WorkDuration.TabIndex = 2;
            WorkDuration.Value = new decimal(new int[] { 25, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(102, 58);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 3;
            label2.Text = "minutes";
            // 
            // WaitingTime
            // 
            WaitingTime.AutoSize = true;
            WaitingTime.Font = new Font("Florisa Personal Use", 35.9999962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            WaitingTime.Location = new Point(199, 124);
            WaitingTime.Name = "WaitingTime";
            WaitingTime.Size = new Size(160, 48);
            WaitingTime.TabIndex = 4;
            WaitingTime.Text = "25:00";
            // 
            // ButtonStart
            // 
            ButtonStart.Location = new Point(134, 227);
            ButtonStart.Name = "ButtonStart";
            ButtonStart.Size = new Size(129, 29);
            ButtonStart.TabIndex = 5;
            ButtonStart.Text = "Start";
            ButtonStart.UseVisualStyleBackColor = true;
            // 
            // ButtonStop
            // 
            ButtonStop.Location = new Point(269, 227);
            ButtonStop.Name = "ButtonStop";
            ButtonStop.Size = new Size(129, 29);
            ButtonStop.TabIndex = 6;
            ButtonStop.Text = "Stop";
            ButtonStop.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 95);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 7;
            label4.Text = "Short break:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 124);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 7;
            label5.Text = "Long break:";
            // 
            // ShortBreak
            // 
            ShortBreak.Location = new Point(87, 93);
            ShortBreak.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            ShortBreak.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            ShortBreak.Name = "ShortBreak";
            ShortBreak.Size = new Size(42, 23);
            ShortBreak.TabIndex = 2;
            ShortBreak.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // LongBreak
            // 
            LongBreak.Location = new Point(87, 122);
            LongBreak.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            LongBreak.Minimum = new decimal(new int[] { 20, 0, 0, 0 });
            LongBreak.Name = "LongBreak";
            LongBreak.Size = new Size(42, 23);
            LongBreak.TabIndex = 2;
            LongBreak.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // Lapses
            // 
            Lapses.AutoSize = true;
            Lapses.Location = new Point(12, 157);
            Lapses.Name = "Lapses";
            Lapses.Size = new Size(42, 15);
            Lapses.TabIndex = 8;
            Lapses.Text = "Lapses";
            // 
            // BreakDuration
            // 
            BreakDuration.AutoSize = true;
            BreakDuration.Location = new Point(233, 58);
            BreakDuration.Name = "BreakDuration";
            BreakDuration.Size = new Size(104, 15);
            BreakDuration.TabIndex = 9;
            BreakDuration.Text = "Breaking time 4:49";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 268);
            Controls.Add(BreakDuration);
            Controls.Add(Lapses);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(ButtonStop);
            Controls.Add(ButtonStart);
            Controls.Add(WaitingTime);
            Controls.Add(label2);
            Controls.Add(LongBreak);
            Controls.Add(ShortBreak);
            Controls.Add(WorkDuration);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)WorkDuration).EndInit();
            ((System.ComponentModel.ISupportInitialize)ShortBreak).EndInit();
            ((System.ComponentModel.ISupportInitialize)LongBreak).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private NumericUpDown WorkDuration;
        private Label label2;
        private Label WaitingTime;
        private Button ButtonStart;
        private Button ButtonStop;
        private Label label4;
        private Label label5;
        private NumericUpDown ShortBreak;
        private NumericUpDown LongBreak;
        private Label Lapses;
        private Label BreakDuration;
    }
}
