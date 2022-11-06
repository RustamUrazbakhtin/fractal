namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.startBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.randomRadioButton = new System.Windows.Forms.RadioButton();
            this.manuallyRadioButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.constTwoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.constOneTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.startBtn.Location = new System.Drawing.Point(14, 434);
            this.startBtn.Margin = new System.Windows.Forms.Padding(4);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(100, 28);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "START";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.exitBtn.Location = new System.Drawing.Point(135, 434);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(100, 28);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.Text = "EXIT";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(899, 466);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.randomRadioButton);
            this.panel1.Controls.Add(this.manuallyRadioButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.constTwoTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.constOneTextBox);
            this.panel1.Controls.Add(this.startBtn);
            this.panel1.Controls.Add(this.exitBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(899, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 466);
            this.panel1.TabIndex = 3;
            // 
            // randomRadioButton
            // 
            this.randomRadioButton.AutoSize = true;
            this.randomRadioButton.Location = new System.Drawing.Point(7, 130);
            this.randomRadioButton.Name = "randomRadioButton";
            this.randomRadioButton.Size = new System.Drawing.Size(239, 21);
            this.randomRadioButton.TabIndex = 9;
            this.randomRadioButton.TabStop = true;
            this.randomRadioButton.Text = "Рандомные значения (Random)";
            this.randomRadioButton.UseVisualStyleBackColor = true;
            this.randomRadioButton.CheckedChanged += new System.EventHandler(this.RandomRadioButton_CheckedChanged);
            // 
            // manuallyRadioButton
            // 
            this.manuallyRadioButton.AutoSize = true;
            this.manuallyRadioButton.Location = new System.Drawing.Point(7, 13);
            this.manuallyRadioButton.Name = "manuallyRadioButton";
            this.manuallyRadioButton.Size = new System.Drawing.Size(190, 21);
            this.manuallyRadioButton.TabIndex = 8;
            this.manuallyRadioButton.TabStop = true;
            this.manuallyRadioButton.Text = "Ввод вручную (Manually)";
            this.manuallyRadioButton.UseVisualStyleBackColor = true;
            this.manuallyRadioButton.CheckedChanged += new System.EventHandler(this.ManuallyRadioButton_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Константа cIm:";
            // 
            // constTwoTextBox
            // 
            this.constTwoTextBox.Location = new System.Drawing.Point(14, 102);
            this.constTwoTextBox.Name = "constTwoTextBox";
            this.constTwoTextBox.Size = new System.Drawing.Size(222, 22);
            this.constTwoTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Константа cRe:";
            // 
            // constOneTextBox
            // 
            this.constOneTextBox.Location = new System.Drawing.Point(14, 57);
            this.constOneTextBox.Name = "constOneTextBox";
            this.constOneTextBox.Size = new System.Drawing.Size(222, 22);
            this.constOneTextBox.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(899, 466);
            this.panel2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 466);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Fractal Julia";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox constOneTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox constTwoTextBox;
        private System.Windows.Forms.RadioButton randomRadioButton;
        private System.Windows.Forms.RadioButton manuallyRadioButton;
    }
}

