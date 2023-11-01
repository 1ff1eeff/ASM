namespace ASM
{
    partial class MServicePerformance
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
            button2 = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            button3 = new Button();
            button4 = new Button();
            checkBox1 = new CheckBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            button5 = new Button();
            textBox3 = new TextBox();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(138, 311);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 55;
            button2.Text = "Отмена";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(57, 311);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 54;
            button1.Text = "ОК";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 60);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(201, 23);
            textBox1.TabIndex = 53;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 42);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 46;
            label2.Text = "Адрес (имя) хоста";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(164, 15);
            label1.TabIndex = 45;
            label1.Text = "Работоспособность службы";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 95);
            label3.Name = "label3";
            label3.Size = new Size(127, 15);
            label3.TabIndex = 56;
            label3.Text = "Проверяемый сервис";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 113);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(201, 23);
            comboBox1.TabIndex = 57;
            // 
            // button3
            // 
            button3.Location = new Point(12, 142);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 58;
            button3.Text = "Заполнить";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(93, 142);
            button4.Name = "button4";
            button4.Size = new Size(120, 23);
            button4.TabIndex = 59;
            button4.Text = "Узнать состояние";
            button4.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(12, 171);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(135, 19);
            checkBox1.TabIndex = 60;
            checkBox1.Text = "Нужна авторизация";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 1);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 63;
            label4.Text = "Логин";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(3, 23);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(198, 23);
            textBox2.TabIndex = 62;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 58);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 61;
            label5.Text = "Пароль";
            // 
            // button5
            // 
            button5.Location = new Point(170, 75);
            button5.Name = "button5";
            button5.Size = new Size(31, 23);
            button5.TabIndex = 65;
            button5.Text = "👁";
            button5.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(5, 76);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(159, 23);
            textBox3.TabIndex = 66;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label5);
            panel1.Enabled = false;
            panel1.Location = new Point(8, 196);
            panel1.Name = "panel1";
            panel1.Size = new Size(205, 108);
            panel1.TabIndex = 67;
            // 
            // MServicePerformance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(227, 347);
            Controls.Add(panel1);
            Controls.Add(checkBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MServicePerformance";
            Text = "Работоспособность сервисов";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private Label label3;
        private ComboBox comboBox1;
        private Button button3;
        private Button button4;
        private CheckBox checkBox1;
        private Label label4;
        private TextBox textBox2;
        private Label label5;
        private Button button5;
        private TextBox textBox3;
        private Panel panel1;
    }
}